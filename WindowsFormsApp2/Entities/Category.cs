using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Image stockée sous forme de tableau de bytes
        public byte[] Image { get; set; }
    }
}
