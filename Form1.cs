using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNotifications
{
    public partial class Form1 : Form
    {
        Tester t = new Tester();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string managerEmployeeId = txtManagerEmployeeId.Text;
            if (String.IsNullOrEmpty(managerEmployeeId)) {
                label1.Text = "Enter ManagerEmployeeId";
                return;
            }
            string messageNotification = txtMessageNotification.Text;
            if (String.IsNullOrEmpty(messageNotification))
            {
                label1.Text = "Enter message";
                return;
            }
            int count = t.TestNotification(managerEmployeeId, messageNotification);
            label1.Text = count.ToString() + " sent";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
