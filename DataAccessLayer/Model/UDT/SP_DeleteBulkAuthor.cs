using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFrameworkExtras.EF5;

namespace DataAccessLayer.Model.UDT
{
    [StoredProcedure("DeleteBulkAuthor")]
    public class SP_DeleteBulkAuthor
    {
        [StoredProcedureParameter(SqlDbType.Udt, ParameterName = "DeleteAuthor")]
        public List<UDT_DeleteAuthorType> DeleteAuthorTypes { get; set; }
    }
}
