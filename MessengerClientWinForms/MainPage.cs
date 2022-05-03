using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerClientWinForms
{
    public partial class MainPage : Form
    {
        //private static Authorization aut = new Authorization();
        private static int MessageID = 0;
        private static string UserName;
        private static MessengerAPI API = new MessengerAPI();
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbxChat.HorizontalScrollbar = true;
            Authorization aut = new Authorization();
            aut.Show();
            //this.Enabled = false;
            
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbxAuthorization_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Enabled = false;
            Authorization aut = new Authorization();
            aut.Show();
            
        }     

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            UserName = tbxUserName.Text;
            string Messange = tbxUserMessage.Text;
            if ((UserName.Length > 1) && (UserName.Length > 1))
            {
                Message msg = new Message(UserName, Messange, DateTime.Now);
                API.SendMessage(msg);
                tbxUserMessage.Text = null;

                // Display a horizontal scroll bar.
               // lbxChat.HorizontalScrollbar = true;

                // Create a Graphics object to use when determining the size of the largest item in the ListBox.
               // Graphics g = lbxChat.CreateGraphics();

               // int hzSize = (int)g.MeasureString(lbxChat.Items[lbxChat.Items.Count - 1].ToString(), lbxChat.Font).Width;
                // Set the HorizontalExtent property.
               // lbxChat.HorizontalExtent = hzSize;
               // tbxUserMessage.Text = null;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var getMessage = new Func<Task>(async () =>
            {

                Message msg = await API.GetMessageHTTPAsync(MessageID);
                while (msg != null)
                {
                    lbxChat.Items.Add(msg);
                    MessageID++;
                    msg = await API.GetMessageHTTPAsync(MessageID);
                }
            });
            getMessage.Invoke();
        }
    }
}
