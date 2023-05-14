using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class NotificationDAL:DatabaseAccess

    {
        public DataTable getAllNotification_DAL()
        {
            return getAllNotification_DA_DAL();
        }
        public DataTable getNotificationItem_DAL()
        {
            return getNotificationItem_DA_DAL();
        }
    }
}
