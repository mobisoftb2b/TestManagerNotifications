using NLog;
using RabbitMQManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNotifications
{
    public class Tester
    {
        public delegate void Del(string value);
        RabbitMQManagersApprove m = new RabbitMQManagersApprove();

        
        public Tester()
        {
        }

        
        public void Close()
        {
            m.Close();
        }


        public int TestNotification(string managerEmployeeId, string message) {
            return m.TestNotification(managerEmployeeId, message);
        }
    }
}

