using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkExtras.EF5;


namespace DataAccessLayer.Model.UDT
{
    [UserDefinedTableType("DeleteAuthorType")]
    public class UDT_DeleteAuthorType
    {
        [UserDefinedTableTypeColumn(1)] 
        public int Id { get; set; }
    }
}
