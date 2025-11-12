using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Entities;
using WindowsFormsApp1.Data.Repositories;
using BunifuButtonType = Bunifu.UI.WinForms.BunifuButton.BunifuButton;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly INoteRepository _noteRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITaskRepository _taskRepository;

        private Control currentControl = null;
        private object user;

        private int targetIndicatorY;
        private const int animationEasingFactor = 4;
        private bool isWindowMaximized = false;

        private readonly Color activeBackColor = Color.Thistle;
        private readonly Color normalBackColor = Color.White;
        private readonly Color activeTextColor = Color.Purple;
        private readonly Color normalTextColor = Color.DimGray;

        public MainForm(IServiceProvider serviceProvider,
                        INoteRepository noteRepository,
                        ICategoryRepository categoryRepository,
                        ITaskRepository taskRepository,
                        object user = null)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _noteRepository = noteRepository;
            _categoryRepository = categoryRepository;
            _taskRepository = taskRepository;

            this.user = user;
        }
        private void loadTodayTasks()
        {

            var allTasks = _taskRepository.GetAll(); ; 

            var filteredTasks = allTasks
                .Where(t => t.DueDate.Date == DateTime.Today)
                .ToList();

            foreach (var task in filteredTasks)
            {
                var taskCard = new TaskCardControl(_taskRepository, task); 
                taskCard.Title = task.Title;
                taskCard.DescriptionRtf = task.Description; 
                taskCard.TaskDate = task.DueDate.ToString("dd/MM/yyyy");              
                flowLayoutPanelToday.Controls.Add(taskCard);
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
      

        private void SetActiveButton(BunifuButtonType activeButton, bool immediate = false)
        {
            if (activeButton == null) return;

            foreach (var control in this.flowLayoutPanelMenu.Controls.OfType<BunifuButtonType>())
            {
                bool isActive = (control == activeButton);
                control.IdleFillColor = isActive ? activeBackColor : normalBackColor;
                control.IdleBorderColor = control.IdleFillColor;
                control.ForeColor = isActive ? activeTextColor : normalTextColor;
            }

            targetIndicatorY = activeButton.Location.Y;
            pnlActiveIndicator.Height = activeButton.Height;

            if (immediate)
            {
                if (indicatorTimer.Enabled) indicatorTimer.Stop();
                pnlActiveIndicator.Location = new Point(pnlActiveIndicator.Location.X, targetIndicatorY);
            }
            else if (!indicatorTimer.Enabled && pnlActiveIndicator.Location.Y != targetIndicatorY)
            {
                indicatorTimer.Start();
            }

            pnlActiveIndicator.Visible = (activeButton != btnLogout);
        }

        private void IndicatorTimer_Tick(object sender, EventArgs e)
        {
            int currentY = pnlActiveIndicator.Location.Y;
            int diff = targetIndicatorY - currentY;
            int step = (int)Math.Ceiling((double)diff / animationEasingFactor);
            if (step == 0 && diff != 0) step = Math.Sign(diff);

            if (Math.Abs(diff) <= Math.Abs(step))
            {
                pnlActiveIndicator.Location = new Point(pnlActiveIndicator.Location.X, targetIndicatorY);
                indicatorTimer.Stop();
            }
            else
            {
                pnlActiveIndicator.Location = new Point(pnlActiveIndicator.Location.X, currentY + step);
            }
        }

        private void ShowControlInPanel(Control controlToShow)
        {
            if (currentControl != null)
            {
                currentControl.Visible = false; 
            }
            pnlMainContent.Controls.Clear();

            if (controlToShow != null)
            {
                currentControl = controlToShow;

                if (controlToShow is Form formToShow)
                {
                    formToShow.TopLevel = false;
                    formToShow.FormBorderStyle = FormBorderStyle.None;
                    formToShow.AutoScaleMode = AutoScaleMode.Dpi;
                }

                controlToShow.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(controlToShow);

                if (controlToShow is Form formToShowAfterAdd)
                {
                    formToShowAfterAdd.Show();
                }

                controlToShow.BringToFront(); 
            }
        }


        #region Window Controls

        private void BtnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = isWindowMaximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            isWindowMaximized = (this.WindowState == FormWindowState.Maximized);
        }

        private void BtnClose_Click(object sender, EventArgs e) => Application.Exit();

        #endregion

        #region Menu Events

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Créer une nouvelle instance de MainForm
            var homeForm = new MainForm(_serviceProvider, _noteRepository, _categoryRepository, _taskRepository);
            homeForm.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as BunifuButtonType);
            ShowControlInPanel(null);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?",
                                "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ShowControlInPanel(null);
                Application.Exit();
            }
        }

       

        private void btnNotes_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as BunifuButtonType);
            var notesForm = _serviceProvider.GetRequiredService<CategoryNote>();
            ShowControlInPanel(notesForm);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as BunifuButtonType);
            var categoriesForm = _serviceProvider.GetRequiredService<AllCategoriesForm>();
            ShowControlInPanel(categoriesForm);
        }

        #endregion

        private void btnTasks_Click(object sender, EventArgs e)
        {
            SetActiveButton(sender as BunifuButtonType);
            var tasksForm = _serviceProvider.GetRequiredService<AllTasksForm>();
            ShowControlInPanel(tasksForm);
        }

        private void loadCategory()
        {
            var allCategories = _categoryRepository.GetAll(); ; // méthode qui récupère les tâches

            var topCategories = allCategories
            .OrderByDescending(c => c.Notes.Count)
            .Take(3)
            .ToList();




            foreach (var category in topCategories)
            {
                var categoryCard = new CategoryCardControl(_categoryRepository, category);
                flowLayoutPanelCategories.Controls.Add(categoryCard);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadTodayTasks();
            loadRecentNotes();
            loadCategory();
        }
    }
}
