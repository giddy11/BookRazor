using BookList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.DB.Mappings
{
    public class BookMap : BaseEntityMap<Book>
    {
        public BookMap()
        {
            Map(book => book.Name);
            Map(book => book.Author);
        }
    }
}
