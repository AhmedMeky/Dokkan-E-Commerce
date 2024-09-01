using Autofac;
using Eldokkan.pl;
using ELDOKKAN.Application.Services;
using ELDOKKAN.Models;
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
            bindingadmin = new BindingSource();
            bindingcategory = new BindingSource();
            bindingCustomer = new BindingSource();

            Navigator = new BindingNavigator();

        }
        BindingSource bindingadmin;
        BindingSource bindingcategory;
        BindingSource bindingCustomer;
        BindingSource bindingSource;

        BindingNavigator Navigator;


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

            var result = admin.GetAllAdmins().Where(p => p.Name == tb_username.Text).ToList();
            if (result.Count > 0)
            {
                MessageBox.Show("user name already exist try another one");
            }
            else
            {
                var re = admin.AddAdmin(new CreateAdminDTO()
                {
                    Name = tb_username.Text,
                    Email = tb_email.Text,
                    Password = PasswordHasher.HashPassword(tb_password.Text),
                    //Password = EncryptionHelper.Encrypt(tb_password.Text),
                });
                MessageBox.Show("Record Inserted successfully.");
            }

        }

        private void Dashborad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void BindControls()
        {
            // tb.DataBindings.Add("Text", bindingSource, "TitleId");
            if (tb_useradminUP.DataBindings.Count == 0)
            {


                tb_useradminUP.DataBindings.Add("Text", bindingadmin, "Name");
                tb_passwordadmin.DataBindings.Add("Text", bindingadmin, "Password");

            }
        }
        private void tabControl3_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            IAdminService admin = autoFac.Resolve<IAdminService>();
            bindingadmin.DataSource = admin.GetAllAdmins().ToList();
            Navigator = new BindingNavigator(bindingadmin);

            BindControls();
            Navigator.Dock = DockStyle.Right;

            this.Controls.Add(Navigator);
            bindingadmin.DataSource = admin.GetAllAdmins();
            bindingadmin.ResetBindings(false);
            //  dtgv_admin.Columns[]
        }

        private void Dashborad_Load(object sender, EventArgs e)
        {


        }

        private void btn_updateAdmin_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            IAdminService admin = autoFac.Resolve<IAdminService>();
            // UpdateAdminDTO update= new UpdateAdminDTO() { AdminID= bindingSource.Current };
            if (bindingadmin.Current is GetAllAdminDTO dTO)
            {
                admin.UpdateAdmin(dTO.AdminID, dTO);

                MessageBox.Show("Updeted Successfuly");

            }
        }

        private void btn_deleteadmin_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            IAdminService admin = autoFac.Resolve<IAdminService>();
            if (bindingadmin.Current is GetAllAdminDTO dTO)
            {
                admin.DeleteAdmin(dTO.AdminID);
                MessageBox.Show("Deleted Successfuly");
            }

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICategoryService category = autoFac.Resolve<ICategoryService>();
            bindingcategory.DataSource = category.GetAllCategories().ToList();
            Navigator = new BindingNavigator(bindingcategory);
            Navigator.Dock = DockStyle.Right;

            this.Controls.Add(Navigator);
            if (tb_category.DataBindings.Count == 0)
            {
                tb_category.DataBindings.Add("Text", bindingcategory, "CategoryName");
                tb_description.DataBindings.Add("Text", bindingcategory, "Description");
            }
        }

        private void btn_saveCategory_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICategoryService category = autoFac.Resolve<ICategoryService>();

            category.AddCategory(new CreateCategoryDTO()
            {
                CategoryName = tb_category.Text,
                Description = tb_category.Text,
            });
            MessageBox.Show("inserted Successfuly!");
            bindingcategory.DataSource = category.GetAllCategories();
            bindingcategory.ResetBindings(false);
        }

        private void btn_updatecategory_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICategoryService category = autoFac.Resolve<ICategoryService>();
            if (bindingcategory.Current is GetAllCategoryDTO dTO)
            {
                category.UpdateCategory(dTO.CategoryID, dTO);
                MessageBox.Show("Updated Successfuly!");
                bindingcategory.DataSource = category.GetAllCategories();
                bindingcategory.ResetBindings(false);

            }
        }

        private void btn_deletecategory_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICategoryService category = autoFac.Resolve<ICategoryService>();
            if (bindingcategory.Current is GetAllCategoryDTO dTO)
            {
                category.DeleteCategory(dTO.CategoryID);
                MessageBox.Show("Delted Successfuly!");
                bindingcategory.DataSource = category.GetAllCategories();

                bindingcategory.ResetBindings(false);


            }
        }


        private void btn_CategorySearch_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICategoryService category = autoFac.Resolve<ICategoryService>();
            bindingcategory.DataSource = category.GetAllCategories()
                                                    .Where(p => p.CategoryName.ToLower().Contains(tb_CategorySearch.Text.ToLower()) ||
                                                    p.Description.ToLower().Contains(tb_CategorySearch.Text.ToLower())).ToList();
            dtgv_categorySearch.DataSource = bindingcategory;

        }

        private void tabControl4_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICategoryService category = autoFac.Resolve<ICategoryService>();

            bindingcategory.DataSource = category.GetAllCategories();
            var data = category.GetAllCategories();
            if (dtgv_categorySearch.DataSource == null)
                dtgv_categorySearch.DataSource = bindingcategory;
            // 011 58 99 19 67
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            IOrderService order = autoFac.Resolve<IOrderService>();
            ICustomerService customer = autoFac.Resolve<ICustomerService>();
            bindingSource.DataSource = order.GetAllOrders().ToList();
            Navigator = new BindingNavigator(bindingSource);
            Navigator.Dock = DockStyle.Right;

            this.Controls.Add(Navigator);
            if (tb_orderID.DataBindings.Count == 0)
            {
                guna2DateTimePicker2.DataBindings.Add("Text", bindingSource, "OrderDate");
                tb_orderID.DataBindings.Add("Text", bindingSource, "OrderID");
                cb_customer.DataSource = customer.GetAllCustomers().Select(p => new { Name = p.Name, CustomerID = p.CustomerID }).ToList();
                cb_customer.DisplayMember = "Name";
                cb_customer.ValueMember = "CustomerID";
                cb_customer.DataBindings.Add("SelectedValue", bindingSource, "CustomerID");

            }
        }

        private void btn_orderDelete_Click(object sender, EventArgs e)
        {

            var autoFac = AutoFac.Inject();
            IOrderService order = autoFac.Resolve<IOrderService>();

            IOrderDetailsService orderdetails = autoFac.Resolve<IOrderDetailsService>();
            if (bindingSource.Current is GetAllOrderDTO dTO)
            {
                //var id = orderdetails.GetAllOrderDetails().Where(d => d.OrderID == dTO.OrderID).Select(d=>d.);
                // orderdetails.DeleteOrderDetails();

            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            IOrderService category = autoFac.Resolve<IOrderService>();
            bindingSource.DataSource = category.GetAllOrders();
            if (dtgv_categorySearch.DataSource == null)
                dtgv_categorySearch.DataSource = bindingSource;
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }
        //customer=====================================================
        private void btn_saveCustomer_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICustomerService customer = autoFac.Resolve<ICustomerService>();
            customer.AddCustomer(new CreateCustomerDTO()
            {
                Name = tb_name.Text,
                Email = tb_email.Text,
                Password = tb_password.Text,
                Address = tb_address.Text,
                Phone = tb_phone.Text,
                PostalCode = tb_PostalCode.Text,
            });
            MessageBox.Show("Created Succefuly!");
            bindingCustomer.DataSource = customer.GetAllCustomers();

            bindingCustomer.ResetBindings(false);
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICustomerService customer = autoFac.Resolve<ICustomerService>();
            if (bindingCustomer.Current is GetAllCustomerDTO dTO)
            {
                customer.UpdateCustomer(dTO.CustomerID, dTO);
                MessageBox.Show("Updated Successfuly");
                bindingCustomer.DataSource = customer.GetAllCustomers();

                bindingCustomer.ResetBindings(false);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICustomerService customer = autoFac.Resolve<ICustomerService>();
            bindingCustomer.DataSource = customer.GetAllCustomers().ToList();
            Navigator = new BindingNavigator(bindingCustomer);
            Navigator.Dock = DockStyle.Right;

            this.Controls.Add(Navigator);
            if (tb_name.DataBindings.Count == 0)
            {
                tb_name.DataBindings.Add("Text", bindingCustomer, "Name");
                guna2TextBox2.DataBindings.Add("Text", bindingCustomer, "Password");
                tb_PostalCode.DataBindings.Add("Text", bindingCustomer, "PostalCode");
                tb_phone.DataBindings.Add("Text", bindingCustomer, "Phone");
                guna2TextBox3.DataBindings.Add("Text", bindingCustomer, "Email");
                tb_address.DataBindings.Add("Text", bindingCustomer, "Address");
            }
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICustomerService customer = autoFac.Resolve<ICustomerService>();
            if (bindingCustomer.Current is GetAllCustomerDTO dTO)
            {
                customer.DeleteCustomer(dTO.CustomerID);
                MessageBox.Show("Deleted Successfuly!");
                bindingCustomer.DataSource = customer.GetAllCustomers();

                bindingCustomer.ResetBindings(false);
            }
        }

        private void tabPage13_Click(object sender, EventArgs e)
        {
            // tb_customerSearch
            var autoFac = AutoFac.Inject();
            ICustomerService customer = autoFac.Resolve<ICustomerService>();
            bindingCustomer.DataSource = customer.GetAllCustomers();
            guna2DataGridView2.DataSource = bindingCustomer;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            ICustomerService customer = autoFac.Resolve<ICustomerService>();
            bindingCustomer.DataSource = customer.GetAllCustomers()
                                                    .Where(p => p.Name.ToLower().Contains(tb_customerSearch.Text.ToLower()) ||
                                                    p.Address.ToLower().Contains(tb_customerSearch.Text.ToLower())||
                                                    p.Email.ToLower().Contains(tb_customerSearch.Text.ToLower())||
                                                    p.Phone.ToLower().Contains(tb_customerSearch.Text.ToLower())||
                                                    p.PostalCode.ToLower().Contains(tb_customerSearch.Text.ToLower())                                                    
                                                    ).ToList();
            guna2DataGridView2.DataSource = bindingCustomer;
        }

        //==============================================

        //==============================================
    }
}
