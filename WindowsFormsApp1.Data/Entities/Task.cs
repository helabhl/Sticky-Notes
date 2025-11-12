using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data.Entities
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string  Status { get; set; }
        [Required]
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }

        
    }
}
