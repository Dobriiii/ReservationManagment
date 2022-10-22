using ReservationManagment.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManagment.View
{
    public partial class LoginView : Form
    {
        LoginController loginController = new LoginController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var message = loginController.ShowMessage(txtLoginName.Text, txtLoginPass.Text);
            if (message != null)
            {
                MessageBox.Show(message);
            }
            else
            {
                ReservationCreateView rcv = new ReservationCreateView();
                this.Hide();
                rcv.Show();
            }
           
        }

        private void btnGoToReg_Click(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
