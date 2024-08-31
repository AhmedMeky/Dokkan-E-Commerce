using PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eldokkan.pl
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void tb_password_Click(object sender, EventArgs e)
        {
            tb_password.Clear();
        }

        private void tb_password_MouseLeave(object sender, EventArgs e)
        {
            if (tb_password.Text == string.Empty)
                tb_password.UseSystemPasswordChar = true;
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            tb_re_password.Clear();
        }

        private void tb_re_password_MouseLeave(object sender, EventArgs e)
        {
            if (tb_re_password.Text == string.Empty)
                tb_re_password.UseSystemPasswordChar = true;
        }

        private void tb_name_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
        }

        private void tb_name_MouseLeave(object sender, EventArgs e)
        {
            if (tb_name.Text == string.Empty)
                tb_name.DefaultText = "Full Name";
        }

        private void tb_address_Click(object sender, EventArgs e)
        {
            tb_address.Clear();
        }

        private void tb_address_MouseLeave(object sender, EventArgs e)
        {
            if (tb_address.Text == string.Empty)
                tb_address.DefaultText = "Address";
        }

        private void tb_email_Click(object sender, EventArgs e)
        {
            tb_email.Clear();
        }

        private void tb_email_MouseLeave(object sender, EventArgs e)
        {
            if (tb_email.Text == string.Empty)
                tb_email.DefaultText = "Email";
        }

        private void tb_phone_Click(object sender, EventArgs e)
        {
            tb_phone.Clear();
        }

        private void tb_phone_MouseLeave(object sender, EventArgs e)
        {
            if (tb_phone.Text == string.Empty)
                tb_phone.DefaultText = "Phone";
        }

        private void tb_PostalCode_Click(object sender, EventArgs e)
        {
            tb_PostalCode.Clear();
        }

        private void tb_PostalCode_MouseLeave(object sender, EventArgs e)
        {
            if (tb_PostalCode.Text == string.Empty)
                tb_PostalCode.DefaultText = "Postal Code";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
