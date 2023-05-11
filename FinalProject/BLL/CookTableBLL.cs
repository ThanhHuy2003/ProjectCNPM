using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.DTO;
using FinalProject.DAL;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace FinalProject.BLL
{
    internal class CookTableBLL
    {
        CookTableDAL cookTableDAL = new CookTableDAL();
        public DataTable populateMenuData_Combo_CookTable_BLL()
        {
            if (cookTableDAL.populateMenuData_Combo_CookTable_DAL().Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return cookTableDAL.populateMenuData_Combo_CookTable_DAL();
            }
        }
    }
}
