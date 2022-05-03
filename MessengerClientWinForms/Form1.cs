using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASPServer;

namespace MessengerClientWinForms
{    
    public partial class Authorization : Form
    {
        private static LoginAPI API = new LoginAPI();
        private static Registration reg = new Registration();

        public Authorization()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {
            
            reg.Show();
            this.Hide();
        }

        private void pbxSend_Click(object sender, EventArgs e)
        {
            string UserLogin = tbxLogin.Text;
            string UserPassword = tbxPassword.Text;
            if (UserLogin.Length == 0 || UserPassword.Length == 0)
            {
                MessageBox.Show("Please enter Login and Password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User User = new User(UserLogin, UserPassword);
            if(!API.SendAuthorization(User))
            {
                MessageBox.Show("Uncorrect Login or Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reg.Close();
            this.Close();
            Program.mp.Enabled = true;
            Program.mp.timer1.Enabled = true;
            Program.mp.TopMost = true;
            Program.mp.gbxSend.Visible = true;
            Program.mp.lblName.Text = User.UserName + " Nikita Nikulin " + User.UserSurname;
            Program.mp.tbxUserName.Text = Program.mp.lblName.Text;
            Program.mp.pbxUser.Visible = true;
            Program.mp.pbxFun.Visible = true;
            Program.mp.pbxCorrect.Visible = true;
            Program.mp.pbxUser.SizeMode = PictureBoxSizeMode.Zoom;
            Program.mp.pbxFun.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            pbxFun.SizeMode = PictureBoxSizeMode.Zoom;
            //tbxLogin.Select();
        }

        private void pbxEye_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '\0')
                tbxPassword.PasswordChar = '*';
            else tbxPassword.PasswordChar = '\0';
        }

        private void lblQowepo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/qowepo");
        }

        private void lblGram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/qowepo");
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
