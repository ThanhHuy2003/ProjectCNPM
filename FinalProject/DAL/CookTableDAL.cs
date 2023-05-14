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
    internal class CookTableDAL: DatabaseAccess
    {
        public DataTable populateMenuData_CookTable_DAL(string type)
        {
            return populateMenuData_DA_DAL(type);
        }
    }
}
