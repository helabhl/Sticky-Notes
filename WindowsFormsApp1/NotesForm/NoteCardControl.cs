using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Data.Entities;
using WindowsFormsApp1.Data.Repositories;

namespace WindowsFormsApp1
{
    public partial class NoteCardControl : UserControl
    {
        private bool isPinned = false;
        private bool isEditing = false;
        private string originalText;
        private string originalRtf;
        private readonly INoteRepository _noteRepository;
        private Note _currentNote;

        public event EventHandler NoteUpdated; 

        public NoteCardControl(INoteRepository noteRepository, Note note)
        {
            InitializeComponent();
            _noteRepository = noteRepository ?? throw new ArgumentNullException(nameof(noteRepository));
            _currentNote = note ?? throw new ArgumentNullException(nameof(note));

            InitializeNote();
            InitializeContextMenu();
            LoadNoteData();
        }

        public string Title
        {
            get => lblCardTitle.Text;
            set
            {
                lblCardTitle.Text = value;
                _currentNote.Title = value;
            }
        }

        public string DescriptionRtf
        {
            get => rtbCardDescription.Rtf;
            set => rtbCardDescription.Rtf = value;
        }

        public string NoteDate
        {
            get => lblDate.Text;
            set => lblDate.Text = value;
        }

        public Color CardColor
        {
            get => this.BackColor;
            set
            {
                this.BackColor = value;
                if (!isEditing) rtbCardDescription.BackColor = value;
                UpdateTextColor();
                _currentNote.ColorHex = ColorTranslator.ToHtml(value);
            }
        }

        public bool IsPinned
        {
            get => isPinned;
            set
            {
                isPinned = value;
                UpdatePinAppearance();
                _currentNote.IsPinned = value;
                SaveChanges();
            }
        }

        private void LoadNoteData()
        {
            Title = _currentNote.Title;
            DescriptionRtf = _currentNote.DescriptionRtf;
            CardColor = ColorTranslator.FromHtml(_currentNote.ColorHex);
            IsPinned = _currentNote.IsPinned;
            NoteDate = _currentNote.ModifiedDate.ToString("dd/MM/yyyy HH:mm");
        }

        private void InitializeNote()
        {
            rtbCardDescription.ReadOnly = true;
            rtbCardDescription.BackColor = this.BackColor;
            rtbCardDescription.BorderStyle = BorderStyle.None;
            UpdateTextColor();
        }

        private void InitializeContextMenu()
        {
            contextMenuOptions = new ContextMenuStrip();

            var editItem = new ToolStripMenuItem("Éditer");
            editItem.Click += editToolStripMenuItem_Click;

            var pinItem = new ToolStripMenuItem("Épingler");
            pinItem.Click += pinToolStripMenuItem_Click;

            var deleteItem = new ToolStripMenuItem("Supprimer");
            deleteItem.Click += deleteToolStripMenuItem_Click;

            var cancelItem = new ToolStripMenuItem("Annuler");
            cancelItem.Click += cancelToolStripMenuItem_Click;
            cancelItem.Visible = false;

            contextMenuOptions.Items.AddRange(new ToolStripItem[] {
                editItem, pinItem, deleteItem, cancelItem
            });

            btnOptions.ContextMenuStrip = contextMenuOptions;
        }

        private void UpdateTextColor()
        {
            Color textColor = IsColorDark(this.BackColor) ? Color.White : Color.Black;
            lblCardTitle.ForeColor = textColor;
            rtbCardDescription.ForeColor = textColor;
            lblDate.ForeColor = textColor;
        }

        private bool IsColorDark(Color color)
        {
            return (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) < 128;
        }

        private void UpdatePinAppearance()
        {
            if (contextMenuOptions.Items.Count > 1)
            {
                contextMenuOptions.Items[1].Text = isPinned ? "Désépingler" : "Épingler";
            }
        }

        private void SaveChanges()
        {
            _currentNote.ModifiedDate = DateTime.Now;
            _noteRepository.Update(_currentNote);
            NoteUpdated?.Invoke(this, EventArgs.Empty); // Trigger the event
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleEditMode();
        }

        private void ToggleEditMode()
        {
            isEditing = !isEditing;

            if (isEditing)
            {
                originalText = rtbCardDescription.Text;
                originalRtf = rtbCardDescription.Rtf;
                rtbCardDescription.ReadOnly = false;
                rtbCardDescription.BackColor = Color.White;
                contextMenuOptions.Items[0].Text = "Sauvegarder";
                contextMenuOptions.Items[3].Visible = true;
                rtbCardDescription.Focus();
            }
            else
            {
                rtbCardDescription.ReadOnly = true;
                rtbCardDescription.BackColor = this.BackColor;
                contextMenuOptions.Items[0].Text = "Éditer";
                contextMenuOptions.Items[3].Visible = false;

                _currentNote.DescriptionRtf = DescriptionRtf;
                SaveChanges();

                NoteDate = _currentNote.ModifiedDate.ToString("dd/MM/yyyy HH:mm");
                MessageBox.Show("Modifications enregistrées.\nDate mise à jour.",
                                "Sauvegarde",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void pinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsPinned = !IsPinned;
            MessageBox.Show($"Note {(IsPinned ? "épinglée" : "désépinglée")}",
                            "Épingler",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette note ?",
                "Confirmer Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                _noteRepository.Delete(_currentNote.Id);
                this.Parent?.Controls.Remove(this);
                this.Dispose();
                MessageBox.Show("Note supprimée avec succès.",
                               "Suppression",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                var result = MessageBox.Show("Annuler toutes les modifications ?",
                                           "Annuler",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    rtbCardDescription.Text = originalText;
                    rtbCardDescription.Rtf = originalRtf;
                    ToggleEditMode();
                }
            }
        }

       

       

        

        private void btnOptions_Click(object sender, EventArgs e)
        {
            contextMenuOptions.Show(btnOptions, new Point(0, btnOptions.Height));
        }
    }
}