using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo4.CLASSES;
using demo4.UTILS;

namespace demo4.FORMS
{
    public partial class LoginForm : Form
    {
        private User User;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                User = DataWork.GetUser(LoginTxt.Text, PasswordTxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            this.Hide();
            MainForm MF = new MainForm(User);
            MF.ShowDialog();

            LoginTxt.Text = String.Empty;
            PasswordTxt.Text = String.Empty;

            try
            {
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
