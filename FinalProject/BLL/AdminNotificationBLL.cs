using FinalProject.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    internal class AdminNotificationBLL
    {
        public DataTable getAllNotification()
        {
            NotificationDAL ehe = new NotificationDAL();
            return ehe.getAllNotification_DAL();
        }
    }
}
