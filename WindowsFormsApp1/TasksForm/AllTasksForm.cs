using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data.Entities;
using WindowsFormsApp1.Data.Repositories;

namespace WindowsFormsApp1
{
    public partial class AllTasksForm : Form
    {
        private readonly ITaskRepository _taskRepository;


        public AllTasksForm(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
            InitializeComponent();
            LoadExistingTasks_priority();
            LoadExistingTasks_status();

        }

        private void LoadExistingTasks_priority()
        {
            var tasks = _taskRepository.GetAll();
            foreach (var task in tasks)
            {
                AddTaskToUI_priority(task);
            }
        }

        public void AddTaskToUI_priority(Data.Entities.Task task)
        {
            // Créer une instance de notre contrôle utilisateur NoteCardControl
            var taskCard = new TaskCardControl(_taskRepository, task);
            taskCard.TaskUpdated += (updatedTask) =>
            {
                AddTaskToUI_priority(updatedTask);
            };


            // Définir les propriétés de la carte visuelle
            taskCard.Title = task.Title;
            taskCard.DescriptionRtf = task.Description; // Important: utiliser RTF
            taskCard.TaskDate = task.DueDate.ToString("dd/MM/yyyy");
            
            switch (task.Priority)
            {
                case "Urgent":
                    flowLayoutPanelUrgent.Controls.Add(taskCard);
                    break;
                case "High Priority":
                    flowLayoutPanelHighPriority.Controls.Add(taskCard);
                    break;
                case "Medium":
                    flowLayoutPanelMedium.Controls.Add(taskCard);
                    break;
                case "Low Priority":
                    flowLayoutPanelLowPriority.Controls.Add(taskCard);
                    break;
                default:
                    MessageBox.Show($"Priorité inconnue pour la tâche '{task.Title}': '{task.Priority}'");
                    break;
            }
        }

        public void AddTaskToUI_status(Data.Entities.Task task)
        {
            // Créer une instance de notre contrôle utilisateur NoteCardControl
            var taskCard = new TaskCardControl(_taskRepository, task);
            taskCard.TaskUpdated += (updatedTask) =>
            {
                AddTaskToUI_status(updatedTask);
            };


            // Définir les propriétés de la carte visuelle
            taskCard.Title = task.Title;
            taskCard.DescriptionRtf = task.Description; // Important: utiliser RTF
            taskCard.TaskDate = task.DueDate.ToString("dd/MM/yyyy");
            switch (task.Status)
            {
                case "To Do":
                    flowLayoutPanelToDo.Controls.Add(taskCard);
                    break;
                case "In Progress":
                    flowLayoutPanelInProgress.Controls.Add(taskCard);
                    break;
                case "Done":
                    flowLayoutPanelDone.Controls.Add(taskCard);
                    break;
                case "Delayed":
                    flowLayoutPanelDelayed.Controls.Add(taskCard);
                    break;
                default:
                    MessageBox.Show("Status inconnue !");
                    break;
            }
        }

        private void LoadExistingTasks_status()
        {
            var tasks = _taskRepository.GetAll();
            foreach (var task in tasks)
            {
                AddTaskToUI_status(task);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifie si l'option sélectionnée est "priority"
            if (cmbSort.SelectedItem != null && cmbSort.SelectedItem.ToString() == "Priority")
            {
                panelPriority.Visible = true;


            }
            else if (cmbSort.SelectedItem != null && cmbSort.SelectedItem.ToString() == "Status")
            {
                panelPriority.Visible = false;
                panelStatus.Visible = true; // Afficher le panel
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Créer et afficher NoteForm comme une boîte de dialogue


            using (var taskForm = new TaskForm())
            {
                if (taskForm.ShowDialog(this) == DialogResult.OK)
                {
                    var newTask = new Data.Entities.Task
                    {
                        Title = taskForm.Title,
                        Description = taskForm.DescriptionRtf,
                        Priority = taskForm.Priority,
                        Status = taskForm.Status,
                        DueDate = taskForm.TaskDate,
                    };
                    _taskRepository.Add(newTask);
                    AddTaskToUI_priority(newTask);
                    AddTaskToUI_status(newTask);
                }
  

            }
        }

        
    }
}
