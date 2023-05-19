﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.DTO;
using FinalProject.DAL;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using Krypton.Toolkit;

namespace FinalProject.BLL
{
    internal class AdminUserBLL
    {
        public DataTable getAllUser()
        {
            UserCRUD_DAL ehe = new UserCRUD_DAL();
            return ehe.getAllUser_DAL();
        }
        public DataTable searchUser(String key)
        {
            UserCRUD_DAL data = new UserCRUD_DAL();
            return data.searchUser_DAL(key);
        }
        public void deleteUser(String id)
        {
            UserCRUD_DAL data = new UserCRUD_DAL();
            data.deleteUser_DAL(id);
        }
        public void updateUser(User user)
        {
            UserCRUD_DAL data = new UserCRUD_DAL();
            data.updateUser_DAL(user);
        }
        public void addUser(User user)
        {
            UserCRUD_DAL data = new UserCRUD_DAL();
            data.addUser_DAL(user);
        }
        public String getIdByUsername(String name)
        {
            UserCRUD_DAL data = new UserCRUD_DAL();
            return data.getIdByUsername_DAL(name);
        }
        public User getUserByID(String id)
        {
            UserCRUD_DAL data = new UserCRUD_DAL();
            User newUser = new User();
            foreach(DataRow row in data.getUserByID(id).Rows)
            {
                newUser.fullName = row["fullName"].ToString();
                newUser.emailAddress = row["emailAddress"].ToString();
                newUser.contactAddress = row["contactAddress"].ToString();
                newUser.phoneNumber = row["phoneNumber"].ToString();
                newUser.userName = row["userID"].ToString();
                newUser.userPassword = row["userPassword"].ToString();
                newUser.userRole = row["userRole"].ToString();
            }
            return newUser;
        }
    }
}
