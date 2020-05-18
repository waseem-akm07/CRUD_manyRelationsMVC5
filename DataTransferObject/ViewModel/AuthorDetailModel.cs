using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.ViewModel
{
    public class AuthorDetailModel
    {
        public int DetailId { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public int DetailAuthorId { get; set; }
       
    }
}
