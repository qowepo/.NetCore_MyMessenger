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
    public partial class Registration : Form
    {
        private static LoginAPI API = new LoginAPI();
        private static Authorization aut = new Authorization();
        public Registration()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void lblAuthorization_Click(object sender, EventArgs e)
        {
            
            aut.Show();
            this.Hide();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mp.Enabled = true;
        }

        private void pbxSend_Click(object sender, EventArgs e)
        {
            string UserName = tbxName.Text;
            string UserSurname = tbxSurname.Text;
            string UserLogin = tbxLogin.Text;
            string UserPassword = tbxPassword.Text;
            if (UserLogin.Length == 0 || UserPassword.Length == 0)
            {
                MessageBox.Show("Please enter Login and Password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User User = new User(UserName, UserSurname, UserLogin, UserPassword);
            if (!API.SendRegistration(User))
            {
                MessageBox.Show("Registration failed, try changing your Login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            aut.Close();
            this.Close();
            Program.mp.Enabled = true;
            Program.mp.timer1.Enabled = true;
            Program.mp.TopMost = true;
            Program.mp.gbxSend.Visible = true;
            Program.mp.lblName.Text = " " + User.UserName + " " + User.UserSurname + " ";
            Program.mp.tbxUserName.Text = Program.mp.lblName.Text;
            Program.mp.pbxUser.Visible = true;
            Program.mp.pbxFun.Visible = true;
            Program.mp.pbxCorrect.Visible = true;
            Program.mp.pbxUser.SizeMode = PictureBoxSizeMode.Zoom;
            Program.mp.pbxFun.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void Registration_Load(object sender, EventArgs e)
        {
            pbxFun.SizeMode = PictureBoxSizeMode.Zoom;
            tbxName.Select();
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
    }
}
