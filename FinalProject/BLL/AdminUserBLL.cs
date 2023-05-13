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
    }
}
