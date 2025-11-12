using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    // Classe statique pour la méthode d'extension
    public static class ServiceCollectionExtensions
    {
        // Méthode d'extension pour enregistrer les formulaires
        public static void RegisterForms(this IServiceCollection services)
        {
            // Enregistrer les formulaires dans le conteneur de services
            services.AddTransient<MainForm>();      // Formulaire principal
            services.AddTransient<SigninForm>();      // Formulaire principal
            services.AddTransient<AllCategoriesForm>();      // Formulaire principal
            services.AddTransient<CategoryNote>();  // Formulaire affichant toutes les notes
            services.AddTransient<AllTasksForm>();  // Formulaire affichant toutes les notes
            services.AddTransient<DashboardForm>();
        }
    }
}
