using Autofac;
using Eldokkan.pl;
using ELDOKKAN.Application.Services;
using ELDOKKAN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            //Product TAB Dashboards
            IProService = ProductContainer.Resolve<IProductService>();
            ProductBindSource = new BindingSource();



        }
        BindingSource bindingSource;
        BindingNavigator Navigator;

     //Product TAB Dashboards
        Autofac.IContainer ProductContainer = AutoFac.Inject();
        Autofac.IContainer cat = AutoFac.Inject();
        IProductService IProService;
        BindingSource ProductBindSource;
        List<GetAllProductDTO> ProductList;



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
            //Data Grid for Products
        }

        private void btn_updateAdmin_Click(object sender, EventArgs e)
        {
            var autoFac = AutoFac.Inject();
            IAdminService admin = autoFac.Resolve<IAdminService>();
            if (bindingSource.Current is UpdateAdminDTO dTO)
                admin.UpdateAdmin(dTO.AdminID, dTO);
        }

        //Product TAB DAshboard
        private void ProductTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ICategoryService ICatService = cat.Resolve<ICategoryService>();
            BahgatcategBox.DataSource = ICatService.GetAllCategories().ToList();
            BahgatcategBox.DisplayMember = "CategoryName";
            BahgatcategBox.ValueMember = "CategoryID";

            ProductList = IProService.GetAllProducts().ToList();
            ProductBahgatGridView.DataSource = ProductList;
            ProductBahgatGridView.ReadOnly = true;

            ProductBindSource.DataSource = ProductBahgatGridView.DataSource;

            BahgatProText.DataBindings.Clear();
            BahgatUnitsText.DataBindings.Clear();
            BahgatcategBox.DataBindings.Clear();
            BahgatIDLabel.DataBindings.Clear();
            BahgatPriceText.DataBindings.Clear();

            BahgatProText.DataBindings.Add("Text", ProductBindSource, "Name");
            BahgatUnitsText.DataBindings.Add("Text", ProductBindSource, "UnitsInStock");
            BahgatIDLabel.DataBindings.Add("Text", ProductBindSource, "ProductID");
            BahgatPriceText.DataBindings.Add("Text", ProductBindSource, "UnitPrice");

            BahgatcategBox.DataBindings.Add("SelectedValue", ProductBindSource, "CategoryID");
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            ProductBindSource.MoveNext();
        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            ProductBindSource.MovePrevious();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            bool parsing = int.TryParse(BahgatIDLabel.Text.ToString(), out int proID);

            if (parsing == true)
            {
                IProService.DeleteProduct(proID);
            }


        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            CreateProductDTO dto = new CreateProductDTO();
            dto.UnitPrice = decimal.Parse(BahgatUnitsText.Text);
            dto.Name = BahgatProText.Text;
            dto.UnitsInStock = int.Parse(BahgatUnitsText.Text);
            dto.CategoryID = int.Parse(BahgatcategBox.SelectedValue.ToString());
            this.Text = BahgatcategBox.SelectedValue.ToString();

            IProService.AddProduct(dto);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            bool parsing = int.TryParse(BahgatIDLabel.Text.ToString(), out int proID);

            if (parsing == true)
            {
                var product = ProductList.Where(p => p.ProductID == proID).FirstOrDefault();
                IProService.UpdateProduct(proID, product);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BahgatProText.Clear();
            BahgatUnitsText.Clear();
            BahgatIDLabel.Text = " ";
            BahgatPriceText.Clear();
            Bahgataddbtn.Visible = true;


            BahgatProText.DataBindings.Clear();
            BahgatUnitsText.DataBindings.Clear();
            BahgatcategBox.DataBindings.Clear();
            BahgatIDLabel.DataBindings.Clear();
            BahgatPriceText.DataBindings.Clear();

        }


    }
}
