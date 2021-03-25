using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Domain.Test
{
    public class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Author Author { get; set; }
        public long AuthorId { get; set; }

    }
}
