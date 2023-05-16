﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.DAL
{
    internal class CartTableDAL: DatabaseAccess
    {
        public DataTable populateCartData_CartTable_DAL(string userID)
        {
            return populateCartData_DA_DAL(userID);
        }
        public void deleteCartItem_CartTable_DAL(string id)
        {
            deleteCartItem_DA_DAL(id);
        }
        public void insertIntoCartData_CartTable_DAL(string dishID, string dishPicture, string dishName, int dishPrice, int totalQuantity, string userID)
        {
            insertIntoCartData_DA_DAL(dishID, dishPicture, dishName, dishPrice, totalQuantity, userID);
        }
    }
}
