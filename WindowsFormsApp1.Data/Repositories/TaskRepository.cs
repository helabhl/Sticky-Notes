using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Data.Context;
using WindowsFormsApp1.Data.Entities;

namespace WindowsFormsApp1.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;
        public TaskRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Entities.Task task)
        {
            if (task == null) throw new ArgumentNullException(nameof(task));

            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Entities.Task> GetAll()
        {
           return _context.Tasks
                .AsNoTracking()
                .ToList();
        }

        public Entities.Task GetById(int id)
        {
            return _context.Tasks
               .AsNoTracking()
               .FirstOrDefault(n => n.Id == id);
        }

        public IEnumerable<Entities.Task> GetByTitle(string searchText)
        {
            return _context.Tasks
                .Where(n => n.Title.Contains(searchText))
                .ToList();
        }

        

        public void Update(Entities.Task task)
        {
            if (task == null) throw new ArgumentNullException(nameof(task));

            task.DueDate = DateTime.Now;
            _context.Entry(task).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateColor(int TaskId, string colorHex)
        {
            throw new NotImplementedException();
        }

        public void UpdateTaskContent(int id, string title, string rtfContent)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                task.Title = title;
                task.Description = rtfContent;
                _context.SaveChanges();
            }
        }

        
    }
}
