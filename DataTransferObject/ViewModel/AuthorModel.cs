using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.ViewModel
{
    public class AuthorModel
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AuthorDetailModel AuthorDetailModel { get; set; }
        public BookModel BookModel { get; set; }
        public AuthorBookModel AuthorBookModel { get; set; }
    }
}
