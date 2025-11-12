using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApp1.Data.Entities;

namespace WindowsFormsApp1.Data.Repositories
{
    public interface ITaskRepository
    {
        // Opérations CRUD de base
        Task GetById(int id);
        IEnumerable<Task> GetAll();
        void Add(Task task);
        void Update(Task task);
        void Delete(int id);

        // Fonctionnalités spécifiques
        IEnumerable<Task> GetByTitle(string searchText);
        void UpdateColor(int taskId, string colorHex);

        // Méthodes pour l'UI
        void UpdateTaskContent(int id, string title, string rtfContent);
    }
}
