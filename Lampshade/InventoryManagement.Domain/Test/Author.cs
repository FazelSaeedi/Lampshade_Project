using System.Collections.Generic;

namespace InventoryManagement.Domain.Test
{
    public class Author
    {
        public long Id { get; set; }
        public string Name { get; set; }


        public List<Book> Books { get; set; }
    }
}