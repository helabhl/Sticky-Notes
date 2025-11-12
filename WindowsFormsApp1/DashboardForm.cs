using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.Data.Repositories;

namespace WindowsFormsApp1
{

    public partial class DashboardForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly INoteRepository _noteRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITaskRepository _taskRepository;
        public DashboardForm(IServiceProvider serviceProvider,
                        INoteRepository noteRepository,
                        ICategoryRepository categoryRepository,
                        ITaskRepository taskRepository)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _noteRepository = noteRepository;
            _categoryRepository = categoryRepository;
            _taskRepository = taskRepository;

        }
        private void loadTodayTasks()
        {

            // Exemple : liste de tâches
            var allTasks = _taskRepository.GetAll(); ; // méthode qui récupère les tâches

            // LINQ : tâches non terminées, triées par date d’échéance
            var filteredTasks = allTasks
                .Where(t => t.DueDate.Date == DateTime.Today)
                .ToList();



            // Ajouter chaque tâche sous forme de TaskCardControl
            foreach (var task in filteredTasks)
            {
                var taskCard = new TaskCardControl(_taskRepository, task); // ton UserControl
                taskCard.Title = task.Title;
                taskCard.DescriptionRtf = task.Description; // Important: utiliser RTF
                taskCard.TaskDate = task.DueDate.ToString("dd/MM/yyyy");              // méthode à définir pour remplir le control
                flowLayoutPanelToDo.Controls.Add(taskCard);
            }

        }

        private void loadRecentNotes()
        {
            // Récupérer la liste de toutes les tâches
            var allNotes = _noteRepository.GetAll();
            // LINQ : sélectionner les 3 tâches avec les dates de note les plus récentes
            var recentNotes = allNotes
                .OrderByDescending(t => t.CreatedAt)
                .Take(3)
                .ToList();

            foreach (var note in recentNotes)
            {
                var noteCard = new NoteCardControl(_noteRepository, note);
                flowLayoutPanelNotes.Controls.Add(noteCard);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadTodayTasks();
            loadRecentNotes();
        }


    }
}
