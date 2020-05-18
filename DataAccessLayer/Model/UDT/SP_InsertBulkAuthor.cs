using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFrameworkExtras.EF5;

namespace DataAccessLayer.Model.UDT
{
    [StoredProcedure("InsertBulkAuthore")]
    public class SP_InsertBulkAuthor
    {
        [StoredProcedureParameter(SqlDbType.Udt, ParameterName = "bulkAuthor")]
        public List<UDT_InsertAuthorType> InsertAuthorTypes { get; set; }
    }
}
