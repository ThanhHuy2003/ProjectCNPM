using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class CartTableDAL: DatabaseAccess
    {
        public DataTable populateCartData_CartTable_DAL()
        {
            return populateCartData_DA_DAL();
        }
        public void deleteCartItem_CartTable_DAL(string id)
        {
            deleteCartItem_DA_DAL(id);
        }
    }
}
