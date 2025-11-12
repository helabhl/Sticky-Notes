using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WindowsFormsApp1.Data.Context;
using WindowsFormsApp1.Data.Entities;

namespace WindowsFormsApp1.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Category category)
        {
            if (category == null) throw new ArgumentNullException(nameof(category));

            category.CreatedAt = DateTime.Now;
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            if (category == null) throw new ArgumentNullException(nameof(category));

            var existing = _context.Categories.Find(category.Id);
            if (existing == null)
                throw new KeyNotFoundException($"Category with ID {category.Id} not found.");

            existing.Name = category.Name;
            existing.ColorHex = category.ColorHex;
            existing.Icon = category.Icon;

            _context.Entry(existing).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int categoryId)
        {
            var category = _context.Categories
                .Include(c => c.Notes) // Charger les notes associées
                .FirstOrDefault(c => c.Id == categoryId);

            if (category == null)
                throw new KeyNotFoundException($"Category with ID {categoryId} not found.");

            // Détacher les notes de cette catégorie avant suppression
            foreach (var note in category.Notes)
            {
                note.CategoryId = null;
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories
                .OrderByDescending(c => c.CreatedAt)
                .AsNoTracking()
                .ToList();
        }

        public Category GetById(int categoryId)
        {
            return _context.Categories
                .AsNoTracking()
                .FirstOrDefault(c => c.Id == categoryId);
        }

        public bool Exists(int categoryId)
        {
            return _context.Categories
                .AsNoTracking()
                .Any(c => c.Id == categoryId);
        }
    }
}