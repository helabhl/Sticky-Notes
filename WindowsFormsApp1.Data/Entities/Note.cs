using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace WindowsFormsApp1.Data.Entities
{
    public class Note
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string DescriptionRtf { get; set; }

        [Required]
        [StringLength(7)]
        public string ColorHex { get; set; } = "#FFFFFF";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public bool IsPinned { get; set; }

        // Nouvelle propriété pour la catégorie
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [NotMapped]
        public Color CardColor
        {
            get => ColorTranslator.FromHtml(ColorHex);
            set => ColorHex = ColorTranslator.ToHtml(value);
        }
    }
}
