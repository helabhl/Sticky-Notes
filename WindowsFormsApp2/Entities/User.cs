using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Entities
{
    public class User
    {
        public int Id { get; set; }             // Clé primaire
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Note> Notes { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
