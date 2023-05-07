using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class LoginDAL: DatabaseAccess
    {
        public string checkLoginData_Login_DAL(User tk)
        {
            return checkLoginData_DA_DAL(tk);
        }
        public string SignUp_Login_DAL(User newUser)
        {
            return SignUp_DA_DAL(newUser);
        }
    }
}
