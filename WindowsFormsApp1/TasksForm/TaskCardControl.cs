using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WindowsFormsApp1.Data.Entities;
using WindowsFormsApp1.Data.Repositories;

namespace WindowsFormsApp1
{
    public partial class TaskCardControl : UserControl
    {
        private bool isEditing = false;
        private string originalText;
        private string originalRtf;
        private ITaskRepository _taskRepository;
        private Task _currentTask;
        public event Action<Task> TaskUpdated;




        public TaskCardControl(ITaskRepository taskRepository, Task task)
        {
            InitializeComponent();
            _taskRepository = taskRepository ?? throw new ArgumentNullException(nameof(taskRepository));
            _currentTask = task ?? throw new ArgumentNullException(nameof(task));

            InitializeContextMenu();
            LoadTaskData();
        }
        private void LoadTaskData()
        {
            Title = _currentTask.Title;
            DescriptionRtf = _currentTask.Description;
            TaskDate = _currentTask.DueDate.ToString("dd/MM/yyyy");

        }

        


        

        private void InitializeContextMenu()
        {
            // Create context menu
            contextMenuOptions = new ContextMenuStrip();

            // Add menu items
            var editItem = new ToolStripMenuItem("Éditer");
            editItem.Click += editToolStripMenuItem_Click;


            var deleteItem = new ToolStripMenuItem("Supprimer");
            deleteItem.Click += deleteToolStripMenuItem_Click;

            var cancelItem = new ToolStripMenuItem("Annuler");
            cancelItem.Click += cancelToolStripMenuItem_Click;
            cancelItem.Visible = false;

            contextMenuOptions.Items.AddRange(new ToolStripItem[] {
                editItem, deleteItem, cancelItem
            });

            // Assign to button
            btnOptions.ContextMenuStrip = contextMenuOptions;
        }

        // [Rest of your properties and methods remain the same...]
        public string Title
        {
            get => lblCardTitle.Text;
            set => lblCardTitle.Text = value;
        }

        public string DescriptionRtf
        {
            get => rtbCardDescription.Rtf;
            set => rtbCardDescription.Rtf = value;
        }

        public string TaskDate
        {
            get => lblDate.Text;
            set => lblDate.Text = value;
        }

        

        

       

       

        private void btnOptions_Click(object sender, EventArgs e)
        {
            contextMenuOptions.Show(btnOptions, new Point(0, btnOptions.Height));
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
                contextMenuOptions.Items[0].Text = "Sauvegarder"; // Edit item
                contextMenuOptions.Items[3].Visible = true; // Cancel item
                rtbCardDescription.Focus();
            }
            else
            {
                rtbCardDescription.ReadOnly = true;
                rtbCardDescription.BackColor = this.BackColor;
                contextMenuOptions.Items[0].Text = "Éditer"; // Edit item
                contextMenuOptions.Items[3].Visible = false; // Cancel item
                TaskDate = _currentTask.DueDate.ToString("dd/MM/yyyy");
                MessageBox.Show("Modifications enregistrées.",
                                "Sauvegarde",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTaskFormForEdit();
        }

        private void OpenTaskFormForEdit()
        {
            var form = new TaskForm(
                Title,
                DescriptionRtf,
                _currentTask.DueDate,
                _currentTask.Priority,
                _currentTask.Status
            );

            if (form.ShowDialog() == DialogResult.OK)
            {
               
                // Mettre à jour la tâche liée (si nécessaire pour sauvegarde)
                _currentTask.Title = form.Title;
                _currentTask.Description = form.DescriptionRtf;
                _currentTask.DueDate = form.TaskDate;
                _currentTask.Priority = form.Priority;
                _currentTask.Status = form.Status;

                var result = MessageBox.Show("Voulez-vous sauvegarder les modifications ?",
                                           "Sauvegarder",
                                           MessageBoxButtons.YesNoCancel,
                                           MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Sauvegarder via le repository
                    _taskRepository.Update(_currentTask);
                    this.Parent?.Controls.Remove(this);
                    TaskUpdated?.Invoke(_currentTask); // 🔔 Notifie le parent
                    MessageBox.Show("Modifications enregistrées.",
                              "Sauvegarde",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                }

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette Tache ?",
                "Confirmer Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                _taskRepository.Delete(_currentTask.Id);
                this.Parent?.Controls.Remove(this);
                this.Dispose();
                MessageBox.Show("Tache supprimée avec succès.",
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

        private void rtbCardDescription_Leave(object sender, EventArgs e)
        {
            if (isEditing)
            {
                var result = MessageBox.Show("Voulez-vous sauvegarder les modifications ?",
                                           "Sauvegarder",
                                           MessageBoxButtons.YesNoCancel,
                                           MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        ToggleEditMode();
                        break;
                    case DialogResult.No:
                        rtbCardDescription.Text = originalText;
                        rtbCardDescription.Rtf = originalRtf;
                        ToggleEditMode();
                        break;
                    case DialogResult.Cancel:
                        rtbCardDescription.Focus();
                        break;
                }
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}