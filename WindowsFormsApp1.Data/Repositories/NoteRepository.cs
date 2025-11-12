using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WindowsFormsApp1.Data.Context;
using WindowsFormsApp1.Data.Entities;

namespace WindowsFormsApp1.Data.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppDbContext _context;

        public NoteRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Note GetById(int id)
        {
            try
            {
                return _context.Notes
                    .Include(n => n.Category)
                    .AsNoTracking()
                    .FirstOrDefault(n => n.Id == id);
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error retrieving note by ID", ex);
            }
        }

        public IEnumerable<Note> GetAll()
        {
            try
            {
                return _context.Notes
                    .Include(n => n.Category)
                    .AsNoTracking()
                    .OrderByDescending(n => n.ModifiedDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error retrieving all notes", ex);
            }
        }

        public IEnumerable<Note> GetNotesByCategory(int categoryId)  // Méthode ajoutée
        {
            try
            {
                return _context.Notes
                    .Where(n => n.CategoryId == categoryId)
                    .Include(n => n.Category)
                    .OrderByDescending(n => n.ModifiedDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error retrieving notes by category", ex);
            }
        }

        public IEnumerable<Note> GetNotesWithoutCategory()
        {
            try
            {
                return _context.Notes
                    .Where(n => n.CategoryId == null)
                    .OrderByDescending(n => n.ModifiedDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error retrieving notes without category", ex);
            }
        }

        public void Add(Note note)
        {
            if (note == null)
                throw new ArgumentNullException(nameof(note));

            try
            {
                note.CreatedAt = DateTime.Now;
                note.ModifiedDate = DateTime.Now;

                _context.Notes.Add(note);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error adding new note", ex);
            }
        }

        public void Update(Note note)
        {
            if (note == null)
                throw new ArgumentNullException(nameof(note));

            try
            {
                var existingNote = _context.Notes.Find(note.Id);
                if (existingNote == null)
                    throw new KeyNotFoundException($"Note with ID {note.Id} not found");

                // Mise à jour des propriétés
                existingNote.Title = note.Title;
                existingNote.DescriptionRtf = note.DescriptionRtf;
                existingNote.ColorHex = note.ColorHex;
                existingNote.IsPinned = note.IsPinned;
                existingNote.CategoryId = note.CategoryId;
                existingNote.ModifiedDate = DateTime.Now;

                _context.Entry(existingNote).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error updating note", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var note = _context.Notes.Find(id);
                if (note == null)
                    throw new KeyNotFoundException($"Note with ID {id} not found");

                _context.Notes.Remove(note);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error deleting note", ex);
            }
        }

        public IEnumerable<Note> GetByTitle(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return Enumerable.Empty<Note>();

            try
            {
                return _context.Notes
                    .Where(n => n.Title.Contains(searchText))
                    .Include(n => n.Category)
                    .OrderByDescending(n => n.ModifiedDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error searching notes by title", ex);
            }
        }

        public IEnumerable<Note> GetPinnedNotes()
        {
            try
            {
                return _context.Notes
                    .Where(n => n.IsPinned)
                    .Include(n => n.Category)
                    .OrderByDescending(n => n.ModifiedDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error retrieving pinned notes", ex);
            }
        }

        public void UpdateColor(int noteId, string colorHex)
        {
            if (string.IsNullOrWhiteSpace(colorHex))
                throw new ArgumentException("Color hex cannot be empty", nameof(colorHex));

            try
            {
                var note = _context.Notes.Find(noteId);
                if (note == null)
                    throw new KeyNotFoundException($"Note with ID {noteId} not found");

                note.ColorHex = colorHex;
                note.ModifiedDate = DateTime.Now;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error updating note color", ex);
            }
        }

        public void TogglePinStatus(int noteId)
        {
            try
            {
                var note = _context.Notes.Find(noteId);
                if (note == null)
                    throw new KeyNotFoundException($"Note with ID {noteId} not found");

                note.IsPinned = !note.IsPinned;
                note.ModifiedDate = DateTime.Now;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error toggling pin status", ex);
            }
        }

        public IEnumerable<Note> GetRecentNotes(int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be positive");

            try
            {
                return _context.Notes
                    .OrderByDescending(n => n.ModifiedDate)
                    .Include(n => n.Category)
                    .Take(count)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error retrieving recent notes", ex);
            }
        }

        public void UpdateNoteContent(int id, string title, string rtfContent)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty", nameof(title));

            try
            {
                var note = _context.Notes.Find(id);
                if (note == null)
                    throw new KeyNotFoundException($"Note with ID {id} not found");

                note.Title = title;
                note.DescriptionRtf = rtfContent;
                note.ModifiedDate = DateTime.Now;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error updating note content", ex);
            }
        }
    }

    // Exception personnalisée pour gérer les erreurs de repository
    public class RepositoryException : Exception
    {
        public RepositoryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
