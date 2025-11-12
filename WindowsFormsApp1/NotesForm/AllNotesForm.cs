using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Data.Entities;
using WindowsFormsApp1.Data.Repositories;

namespace WindowsFormsApp1
{
    public partial class CategoryNote : Form
    {
        private readonly INoteRepository _noteRepository;

        public CategoryNote(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
            InitializeComponent();
            ConfigureFlowLayoutPanel();
            LoadExistingNotes();
        }

        private void LoadExistingNotes()
        {
            var notes = _noteRepository.GetAll();
            foreach (var note in notes)
            {
                AddNoteToUI(note);
            }
        }

        private void AddNoteToUI(Note note)
        {
            // Crée une nouvelle instance de NoteCardControl avec le repository et la note
            var noteCard = new NoteCardControl(_noteRepository, note);
            GetNotesContainer()?.Controls.Add(noteCard);
        }

        private FlowLayoutPanel GetNotesContainer()
        {
            return Controls.Find("flowLayoutPanelNotes", true).FirstOrDefault() as FlowLayoutPanel
                ?? Controls.Find("flpNotesContainer", true).FirstOrDefault() as FlowLayoutPanel;
        }

        private void ConfigureFlowLayoutPanel()
        {
            var flp = GetNotesContainer();
            if (flp != null)
            {
                flp.Dock = DockStyle.Fill;
                flp.AutoScroll = true;
                flp.FlowDirection = FlowDirection.LeftToRight; // Affichage horizontal
                flp.WrapContents = true; // Retour automatique
                flp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                flp.Padding = new Padding(10);
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            using (var noteForm = new NoteForm())
            {
                if (noteForm.ShowDialog(this) == DialogResult.OK)
                {
                    var newNote = new Note
                    {
                        Title = noteForm.NoteTitle,
                        DescriptionRtf = noteForm.NoteDescriptionRtf,
                        ColorHex = ColorTranslator.ToHtml(noteForm.NoteBgColor),
                        IsPinned = false,
                        CreatedAt = DateTime.Now,
                        ModifiedDate = DateTime.Now
                    };

                    _noteRepository.Add(newNote);
                    AddNoteToUI(newNote);
                }
            }
        }

        
    }
}