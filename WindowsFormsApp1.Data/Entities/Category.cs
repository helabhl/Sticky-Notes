using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WindowsFormsApp1.Data.Entities;

namespace WindowsFormsApp1.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Note> Notes { get; set; }

        public string ColorHex { get; set; }  // Stocké sous forme "#RRGGBB"
        public byte[] Icon { get; set; } // Image encodée en bytes

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
