using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Context;
using WindowsFormsApp1.Data.Repositories;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Créer un conteneur de services
            var services = new ServiceCollection();

            // Enregistrer les services (DbContext, Repositories, Forms)
            services.AddScoped<AppDbContext>();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            // Enregistrer tous les formulaires utilisés
            services.AddScoped<MainForm>();
            services.AddScoped<SigninForm>();
            services.AddScoped<SignupForm>();
            services.AddScoped<AllCategoriesForm>(); // Ajouter ici AllCategoriesForm
            services.AddScoped<CategoryNote>();      // Ajouter ici AllNotesForm 
            services.AddScoped<AllTasksForm>();

            // Construire le conteneur
            var serviceProvider = services.BuildServiceProvider();

            // Initialisation de l'application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Résoudre et lancer MainForm
            var mainForm = serviceProvider.GetRequiredService<SigninForm>();
            Application.Run(mainForm);
        }
    }
}
