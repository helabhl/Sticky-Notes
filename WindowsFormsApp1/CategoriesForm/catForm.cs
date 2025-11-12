using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Data.Repositories;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Context;

namespace WindowsFormsApp1
{
    public partial class catForm : Form
    {
        // Déclaration de l'événement pour la sauvegarde de la catégorie
        public event Action<string, Color, Image> CategorySaved;

        // Tableau des options de couleurs
        private readonly Color[] _colorOptions = new Color[]
        {
            Color.FromArgb(192, 0, 192),
            Color.FromArgb(255, 99, 71),
            Color.FromArgb(192, 64, 0),
            Color.FromArgb(237, 231, 246),
            Color.FromArgb(225, 245, 254),
            Color.FromArgb(128, 128, 255)
        };

        // Propriétés
        public Color SelectedColor { get; private set; }
        private Image _importedImage;
        private readonly ToolTip _colorToolTip = new ToolTip();

        // Constructeur
        public catForm()
        {
            InitializeComponent();
            SelectedColor = _colorOptions[0];

            // Initialisation des boutons de couleurs
            InitializeColorButtons();
            SetupToolTips();

            // Abonnement à l'événement de clic du bouton de création
            btnCreateNote.Click += btnCreateNote_Click;
            btnImage.Click += btnImage_Click;
            btnCancel.Click += btnCancel_Click;
        }

        // Méthode pour initialiser les boutons de couleurs
        private void InitializeColorButtons()
        {
            Button[] colorButtons = { btnColor1, btnColor2, btnColor3, btnColor4, btnColor5, btnColor6 };

            for (int i = 0; i < colorButtons.Length; i++)
            {
                colorButtons[i].Tag = i;
                colorButtons[i].BackColor = _colorOptions[i];
                colorButtons[i].FlatAppearance.BorderSize = i == 0 ? 2 : 0;
                colorButtons[i].FlatAppearance.BorderColor = Color.Gray;
                colorButtons[i].Click += ColorButton_Click;
            }
        }

        // Méthode pour gérer le clic sur un bouton de couleur
        private void ColorButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            int colorIndex = (int)btn.Tag;
            SelectedColor = _colorOptions[colorIndex];

            foreach (var control in panelColors.Controls.OfType<Button>())
            {
                control.FlatAppearance.BorderSize = 0;
            }

            btn.FlatAppearance.BorderSize = 2;
        }

        // Méthode pour configurer les ToolTips pour les boutons de couleurs
        private void SetupToolTips()
        {
            string[] colorNames = { "Violet", "Tomato", "Orange/Brun", "Lavande", "Bleu glacé", "Bleu pastel" };
            for (int i = 0; i < 6; i++)
            {
                _colorToolTip.SetToolTip(this.Controls.Find($"btnColor{i + 1}", true).First(), colorNames[i]);
            }
        }

        // Méthode de gestion du clic sur le bouton "Annuler"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Méthode de gestion du clic sur le bouton "Créer la catégorie"
        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Veuillez entrer un nom de catégorie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Créer une instance de AppDbContext
            var dbContext = new AppDbContext(); // Instancier AppDbContext ici

            // Créer le repository avec l'instance de AppDbContext
            var repo = new CategoryRepository(dbContext);

            // Vérifier si la catégorie existe déjà (par exemple, en fonction du nom)
            var existingCategory = repo.GetAll().FirstOrDefault(c => c.Name.Equals(txtCategory.Text, StringComparison.OrdinalIgnoreCase));

            if (existingCategory != null)
            {
                MessageBox.Show("Une catégorie avec ce nom existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Création d'une nouvelle catégorie
            var newCategory = new Category
            {
                Name = txtCategory.Text,
                ColorHex = ColorTranslator.ToHtml(SelectedColor),
                Icon = _importedImage != null ? ImageToByteArray(_importedImage) : null
            };

            // Enregistrer la catégorie dans la base de données
            repo.Add(newCategory);

            // Déclenche l'événement CategorySaved avec les données nécessaires
            CategorySaved?.Invoke(txtCategory.Text, SelectedColor, _importedImage);

            // Fermeture du formulaire après la création
            this.Close();
        }


        // Méthode de gestion du clic sur le bouton d'image
        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _importedImage = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Convertir Image en byte[]
        private byte[] ImageToByteArray(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
