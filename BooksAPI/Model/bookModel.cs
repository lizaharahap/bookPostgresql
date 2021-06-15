using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BooksAPI.Model
{
    public class bookModel
    {
        [Key]
        public int book_id { get; set; }
        public string book_name{ get; set; }
        public string book_author { get; set; }
        public string book_isbn { get; set; }
    }
}
