using FinalProject;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class UserCRUD_DAL:DatabaseAccess
    {
        public DataTable getAllUser_DAL()
        {
            return getAllUser_DA_DAL();
        }
        public DataTable searchUser_DAL(String key)
        {
            return searchUser_DA_BLL(key);
        }
        public void deleteUser_DAL(String id)
        {
            deleteUser_DA_BLL(id);
        }
        public void updateUser_DAL(User user)
        {
            updateUser_DA_BLL(user);
        }
        public void addUser_DAL(User user)
        {
            addUser_DA_BLL(user);
        }
        public String getIdByUsername_DAL(String name)
        {
            return getIdByUsername_DA_DAL(name);
        }
    }
}
