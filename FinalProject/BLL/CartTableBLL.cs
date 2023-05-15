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
    internal class CartTableBLL
    {
        CartTableDAL cartTableDAL = new CartTableDAL();
        public DataTable populateCartData_CartTable_BLL(string userID)
        {
            if (cartTableDAL.populateCartData_CartTable_DAL(userID).Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return cartTableDAL.populateCartData_CartTable_DAL(userID);
            }
        }
        public void deleteCartItem_CartTable_BLL(string id)
        {
            cartTableDAL.deleteCartItem_CartTable_DAL(id);
        }
    }
}
