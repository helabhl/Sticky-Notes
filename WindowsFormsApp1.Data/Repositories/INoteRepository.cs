using System;
using System.Collections.Generic;
using WindowsFormsApp1.Data.Entities;

namespace WindowsFormsApp1.Data.Repositories
{
    public interface INoteRepository
    {
        Note GetById(int id);

        IEnumerable<Note> GetAll();

        IEnumerable<Note> GetNotesByCategory(int categoryId);  

        void Add(Note note);

        // Mettre à jour une note existante
        void Update(Note note);

        // Supprimer une note
        void Delete(int id);

        // Rechercher des notes par titre
        IEnumerable<Note> GetByTitle(string searchText);

        // Récupérer les notes épinglées
        IEnumerable<Note> GetPinnedNotes();

        // Mettre à jour la couleur d'une note
        void UpdateColor(int noteId, string colorHex);

        // Basculer le statut épinglé
        void TogglePinStatus(int noteId);

        // Récupérer les notes récentes
        IEnumerable<Note> GetRecentNotes(int count);

        // Récupérer les notes sans catégorie
        IEnumerable<Note> GetNotesWithoutCategory();

        // Mettre à jour le contenu d'une note
        void UpdateNoteContent(int id, string title, string rtfContent);
    }
}
