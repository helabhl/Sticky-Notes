using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string  Status { get; set; }
        public string Priority { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
