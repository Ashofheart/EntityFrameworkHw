using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkHoework.entities
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public int countPages { get; set; }
        public int authorId { get; set; }
        public Author author { get; set; }
        public int publisherId { get; set; }
        public Publisher publisher { get; set; }
    }
}