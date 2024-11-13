using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkHoework.entities
{
    public class Author
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public ICollection<Book> books { get; set; }
    }
}
