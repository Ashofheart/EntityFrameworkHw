using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkHoework.entities
{
    public class Publisher
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Book> books { get; set; }
    }
}