using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
            NoteBgColor = _selectedNoteColor; 
            UpdateColorFeedback(); 
        }
        private void UpdateColorFeedback()
        {
            if (this.Controls.ContainsKey("pnlColorPreview"))
            {
                Panel previewPanel = this.Controls["pnlColorPreview"] as Panel;
                if (previewPanel != null)
                {
                    previewPanel.BackColor = _selectedNoteColor;
                }
            }
            
        }

        private void ToggleFontStyle(FontStyle style)
        {
            if (txtDescription.SelectionLength > 0)
            {
                Font currentFont = txtDescription.SelectionFont ?? txtDescription.Font;
                FontStyle newFontStyle = currentFont.Style;

                // Vérifier si le style est déjà appliqué
                if (currentFont.Style.HasFlag(style))
                {
                    newFontStyle &= ~style; // Enlever le style
                }
                else
                {
                    newFontStyle |= style; // Ajouter le style
                }

                txtDescription.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }
        private void btnBold_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);

        }
        private void btnItalic_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }
        private void btnCrossedOut_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Strikeout);
        }


        private void btnImage_Click(object sender, EventArgs e)
        {
            // Ouvrir la boîte de dialogue pour choisir un fichier d'image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Charger l'image et insérer dans le RichTextBox
                string imagePath = openFileDialog.FileName;
                txtDescription.SelectionFont = new Font(txtDescription.Font, FontStyle.Regular);
                txtDescription.SelectionColor = Color.Black;
                Clipboard.SetImage(Image.FromFile(imagePath));
                txtDescription.Paste();
            }
        }

        public string NoteTitle { get; internal set; }
        public string NoteDescriptionRtf { get; internal set; }
        public Color NoteBgColor { get; internal set; }

        private Color _selectedNoteColor = Color.FromArgb(255, 241, 179); // Jaune pâle par défaut

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedNoteColor = colorDialog.Color;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (txtDescription.SelectionBullet)
            {
                txtDescription.SelectionBullet = false; // Désactiver les puces
            }
            else
            {
                txtDescription.SelectionBullet = true; // Activer les puces
            }
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTitle.Text)) // Validation du titre
            {
                // Populate public properties with the data
                NoteTitle = txtTitle.Text;
                NoteDescriptionRtf = txtDescription.Rtf; // Sauvegarder le contenu RTF
                NoteBgColor = this._selectedNoteColor;

                this.DialogResult = DialogResult.OK; // Signaler le succès
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un titre pour la note.", "Titre Requis",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus(); // Remettre le focus sur le champ titre
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
