using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Entities;
using WindowsFormsApp1.Data.Repositories;

namespace WindowsFormsApp1
{
    public partial class AllCategoriesForm : Form
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly INoteRepository _noteRepo;
        private int? _currentCategoryId = null;

        public AllCategoriesForm(ICategoryRepository categoryRepository, INoteRepository noteRepository)
        {
            InitializeComponent();
            _categoryRepo = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _noteRepo = noteRepository ?? throw new ArgumentNullException(nameof(noteRepository));
            ConfigureNotesPanel();
            LoadCategories();
        }

        private void ConfigureNotesPanel()
        {
            flowLayoutNotes.AutoScroll = true;
            flowLayoutNotes.WrapContents = false;
            flowLayoutNotes.FlowDirection = FlowDirection.LeftToRight; // Horizontal flow

            flowLayoutNotes.Padding = new Padding(10);
        }

        private void LoadCategories()
        {
            try
            {
                flowLayoutPanelCategories.SuspendLayout();
                flowLayoutPanelCategories.Controls.Clear();

                foreach (var category in _categoryRepo.GetAll())
                {
                    var card = CreateCategoryCard(category);
                    flowLayoutPanelCategories.Controls.Add(card);
                }
            }
            finally
            {
                flowLayoutPanelCategories.ResumeLayout(true);
            }
        }

        private CategoryCardControl CreateCategoryCard(Category category)
        {
            var card = new CategoryCardControl();
            card.InitializeCard(
                category.Id,
                category.Name,
                ColorTranslator.FromHtml(category.ColorHex),
                category.CreatedAt,
                GetCategoryImage(category.Icon)
            );

            card.CardClicked += (s, e) => HandleCardClicked(category);
            card.DeleteRequested += (s, e) => HandleDeleteRequested(category);
            card.AddNoteRequested += (s, e) => HandleAddNoteRequested(category);

            return card;
        }

        private Image GetCategoryImage(byte[] iconBytes)
        {
            if (iconBytes?.Length > 0)
            {
                using (var ms = new MemoryStream(iconBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        private void HandleCardClicked(Category category)
        {
            _currentCategoryId = category.Id;
            LoadNotesForCategory(category.Id);
        }

        private void HandleDeleteRequested(Category category)
        {
            var result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer la catégorie '{category.Name}' ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _categoryRepo.Delete(category.Id);
                    LoadCategories();
                    if (_currentCategoryId == category.Id)
                    {
                        flowLayoutNotes.Controls.Clear();
                        _currentCategoryId = null;
                    }
                    ShowSuccessMessage("Catégorie supprimée avec succès");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Erreur lors de la suppression : {ex.Message}");
                }
            }
        }

        private void HandleAddNoteRequested(Category category)
        {
            CreateNoteForCategory(category.Id);
        }

        private void LoadNotesForCategory(int categoryId)
        {
            try
            {
                flowLayoutNotes.SuspendLayout();
                flowLayoutNotes.Controls.Clear();

                var notes = _noteRepo.GetNotesByCategory(categoryId)
                    .OrderByDescending(n => n.ModifiedDate)
                    .ToList();

                if (!notes.Any())
                {
                    var lblNoNotes = new Label
                    {
                        Text = "Aucune note dans cette catégorie",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10, FontStyle.Italic),
                        ForeColor = Color.Gray
                    };
                    flowLayoutNotes.Controls.Add(lblNoNotes);
                    return;
                }

                foreach (var note in notes)
                {
                    var noteCard = new NoteCardControl(_noteRepo, note)
                    {
                        Margin = new Padding(5) // On laisse la largeur du control lui-même
                    };

                    noteCard.NoteUpdated += (s, e) =>
                    {
                        LoadNotesForCategory(categoryId);
                    };

                    flowLayoutNotes.Controls.Add(noteCard);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Erreur de chargement des notes : {ex.Message}");
            }
            finally
            {
                flowLayoutNotes.ResumeLayout(true);
            }
        }


        private void CreateNoteForCategory(int categoryId)
        {
            using (var noteForm = new NoteForm())
            {
                if (noteForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var newNote = new Note
                        {
                            Title = noteForm.NoteTitle,
                            DescriptionRtf = noteForm.NoteDescriptionRtf,
                            CategoryId = categoryId,
                            ColorHex = ColorTranslator.ToHtml(noteForm.NoteBgColor),
                            CreatedAt = DateTime.Now,
                            ModifiedDate = DateTime.Now
                        };

                        _noteRepo.Add(newNote);
                        LoadNotesForCategory(categoryId);
                        ShowSuccessMessage("Note créée avec succès !");
                    }
                    catch (Exception ex)
                    {
                        ShowErrorMessage($"Erreur lors de la création de la note : {ex.Message}");
                    }
                }
            }
        }

        

        #region Helpers
        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        private void OnCategorySaved(string name, Color color, Image img)
        {
            LoadCategories(); // Recharger après ajout
        }


        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            var form = new catForm();
            form.CategorySaved -= OnCategorySaved;  // Désabonne d'abord, au cas où
            form.CategorySaved += OnCategorySaved;  // Puis réabonne
            form.ShowDialog();
        }
    }
}
