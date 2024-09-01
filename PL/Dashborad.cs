using Autofac;
using Eldokkan.pl;
using ELDOKKAN.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Dashborad : Form
    {

        public Dashborad()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            Navigator = new BindingNavigator();

        }
        BindingSource bindingSource;
        BindingNavigator Navigator;

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }
        private bool IsValidPassword(string password)
        {
            // Adjust the regex pattern to match your password requirements
            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            var regex = new Regex(passwordPattern);
            return regex.IsMatch(password);
        }
        private void tb_password_MouseLeave(object sender, EventArgs e)
        {
            if (!IsValidPassword(tb_password.Text))
            {
                // MessageBox.Show("Password must be at least 8 characters long, include uppercase letters, numbers, and special characters.");
                guna2HtmlLabel3.Text = "Password must be at least 8 characters long, include uppercase , numbers, special characters.";
                guna2HtmlLabel3.ForeColor = Color.Red;
                tb_password.Focus();
            }
            else
            {
                guna2HtmlLabel3.Text = "Password";
                guna2HtmlLabel3.ForeColor = Color.Black;
            }
        }

        private void tb_repassword_MouseLeave(object sender, EventArgs e)
        {
            if (tb_password.Text != tb_repassword.Text)
            {
                //MessageBox.Show("Passwords do not match.");
                guna2HtmlLabel4.Text = "Passwords do not match.";
                guna2HtmlLabel4.ForeColor = (Color.Red);
                guna2HtmlLabel4.Focus();
            }
            else
            {
                guna2HtmlLabel4.Text = "renter Password";
                guna2HtmlLabel4.ForeColor = (Color.Black);
            }
        }
        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            var regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }
        private void tb_email_MouseLeave(object sender, EventArgs e)
        {
            if (!IsValidEmail(tb_email.Text))
            {
                //  MessageBox.Show("Please enter a valid email address.");
                guna2HtmlLabel2.Text = "Please enter a valid email address.";
                guna2HtmlLabel2.ForeColor = Color.Red;
                tb_email.Focus();
            }
            else
            {
                guna2HtmlLabel2.Text = "Email";
                guna2HtmlLabel2.ForeColor = Color.Black;
            }
        }
        private bool ValidateName(string name)
        {
            string NamePattern = @"^[A-Za-z\s]{3,50}$";

            Regex regex = new Regex(NamePattern);

            return regex.IsMatch(name);
        }
        private void tb_username_MouseLeave(object sender, EventArgs e)
        {
            if (ValidateName(tb_username.Text))
            {
                guna2HtmlLabel1.Text = "Full Name";
                guna2HtmlLabel1.ForeColor = Color.Black;
            }
            else
            {
                tb_username.BackColor = Color.LightCoral;
                guna2HtmlLabel1.Text = "Enter Vaild Name";
                guna2HtmlLabel1.ForeColor = Color.Red;
                tb_username.Focus();
            }
        }

        private void btn_saveAdmin_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            IAdminService admin = autoFac.Resolve<IAdminService>();
            var re = admin.AddAdmin(new CreateAdminDTO()
            {
                Name = tb_username.Text,
                Email = tb_email.Text,
                Password = PasswordHasher.HashPassword(tb_password.Text),
                //Password = EncryptionHelper.Encrypt(tb_password.Text),
            });
            MessageBox.Show("Record Inserted successfully.");


        }

        private void Dashborad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void BindControls()
        {
            // tb.DataBindings.Add("Text", bindingSource, "TitleId");
            tb_useradminUP.DataBindings.Add("Text", bindingSource, "Name");
            tb_passwordadmin.DataBindings.Add("Text", bindingSource, "Password");
        }
        private void tabControl3_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            IAdminService admin = autoFac.Resolve<IAdminService>();
            bindingSource.DataSource = admin.GetAllAdmins().ToList();
            Navigator = new BindingNavigator(bindingSource);

            BindControls();
            Navigator.Dock = DockStyle.Right;

            this.Controls.Add(Navigator);
            //  dtgv_admin.Columns[]
        }

        private void Dashborad_Load(object sender, EventArgs e)
        {


        }

        private void btn_updateAdmin_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            IAdminService admin = autoFac.Resolve<IAdminService>();
            if (bindingSource.Current is UpdateAdminDTO dTO)
                admin.UpdateAdmin(dTO.AdminID,dTO);
        }
    }
}
