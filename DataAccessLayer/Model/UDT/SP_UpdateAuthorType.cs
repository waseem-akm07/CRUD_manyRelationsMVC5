using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityFrameworkExtras.EF5;

namespace DataAccessLayer.Model.UDT
{
    [StoredProcedure("UpdateBulkAuthor")]
    public class SP_UpdateAuthorType
    {
        [StoredProcedureParameter(SqlDbType.Udt, ParameterName = "UpdateAuthor")]
        public List<UDT_UpdateAuthorType> UpdateAuthorTypes { get; set; }
    }
}
