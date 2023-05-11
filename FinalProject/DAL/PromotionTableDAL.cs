using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class PromotionTableDAL: DatabaseAccess
    {
        public DataTable populatePromotionData_PromotionTable_DAL()
        {
            return populatePromotionData_DA_DAL();
        }
    }
}
