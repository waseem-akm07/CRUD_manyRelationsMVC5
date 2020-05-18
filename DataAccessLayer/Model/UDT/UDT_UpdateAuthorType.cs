using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkExtras.EF5;

namespace DataAccessLayer.Model.UDT
{
    [UserDefinedTableType("UpdateAuthorType")]
    public class UDT_UpdateAuthorType
    {
       

        [UserDefinedTableTypeColumn(1)]
        public int AuthorId { get; set; }

        [UserDefinedTableTypeColumn(2)]
        public string FirstName { get; set; }

        [UserDefinedTableTypeColumn(3)]
        public string LastName { get; set; }

        [UserDefinedTableTypeColumn(4)]
        public int DetailId { get; set; }

        [UserDefinedTableTypeColumn(5)]
        public DateTime Birthday { get; set; }

        [UserDefinedTableTypeColumn(6)]
        public string Address { get; set; }

        [UserDefinedTableTypeColumn(7)]
        public int DetailAuthorId { get; set; }

        [UserDefinedTableTypeColumn(8)]
        public int BookId { get; set; }

        [UserDefinedTableTypeColumn(9)]
        public string Title { get; set; }

        [UserDefinedTableTypeColumn(10)]
        public string About { get; set; }

        [UserDefinedTableTypeColumn(11)]
        public int MapId { get; set; }

        [UserDefinedTableTypeColumn(12)]
        public int MapAuthorId { get; set; }

        [UserDefinedTableTypeColumn(13)]
        public int MapBookId { get; set; }
    }
}
