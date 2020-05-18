using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkExtras.EF5;

namespace DataAccessLayer.Model.UDT
{
    [UserDefinedTableType("InsertAuthorType")]
    public class UDT_InsertAuthorType
    {
        [UserDefinedTableTypeColumn(1)]
        public string FirstName { get; set; }

        [UserDefinedTableTypeColumn(2)]
        public string LastName { get; set; }

        [UserDefinedTableTypeColumn(3)]
        public DateTime Birthday { get; set; }

        [UserDefinedTableTypeColumn(4)]
        public string Address { get; set; }

        [UserDefinedTableTypeColumn(5)]
        public string Title { get; set; }

        [UserDefinedTableTypeColumn(6)]
        public string About { get; set; }
    }
}
