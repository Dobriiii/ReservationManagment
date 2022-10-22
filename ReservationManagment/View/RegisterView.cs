using ReservationManagment.Controller;
using ReservationManagment.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManagment.View
{
    public partial class RegisterView : Form
    {
        RegisterController registerController = new RegisterController();
        public RegisterView()
        {
            InitializeComponent();
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Hide();
        }

        private void btnRegCreate_Click(object sender, EventArgs e)
        {
            UserTable userTable = new UserTable();
            if (txtRegUName.Text == String.Empty)
            {
                MessageBox.Show("Please fill the username!");
            }

           
            else if (txtRegPass.Text == String.Empty)
            {
                MessageBox.Show("Please fill the password!");
            }

            else
            {
                userTable.Username = txtRegUName.Text;
                userTable.Password = txtRegPass.Text;
                userTable.PhoneNumber = txtRegPN.Text;
                registerController.AddUser(userTable);
                MessageBox.Show("User is registered");
                LoginView loginView = new LoginView();
                this.Hide();
                loginView.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
