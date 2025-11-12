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
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        public string Title { get; private set; }
        public String DescriptionRtf { get; private set; }
        public DateTime TaskDate { get; private set; }
        public String Priority { get; private set; }
        public String Status { get; private set; }

        public TaskForm(string title, string descriptionRtf, DateTime taskDate, string priority, string status)
        {
            InitializeComponent();
            txtTitle.Text = title;
            txtDescription.Rtf = descriptionRtf;
            dueDate.Value = taskDate;
            cmbPriority.Text = priority;
            cmbStatus.Text = status;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtTitle.Text)) // Validation du titre
            {
                // Populate public properties with the data
                Title = txtTitle.Text;
                DescriptionRtf = txtDescription.Rtf; // Sauvegarder le contenu RTF
                TaskDate = dueDate.Value;
                Priority= cmbPriority.Text;
                Status= cmbStatus.Text;
                this.DialogResult = DialogResult.OK; // Signaler le succès
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un titre pour la Tache.", "Titre Requis",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus(); // Remettre le focus sur le champ titre
            }
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}


