using Autofac;
using Eldokkan.Application.Service;
using Eldokkan.Dto.Product;
using Eldokkan.pl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IContainer = Autofac.IContainer;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PL
{

    public partial class FrontEnd : Form
    {


        private int currentPage;
        int size;



        List<GetAllProductDtos> CartList;
        BindingNavigator bindingNavigator;
        BindingSource PrdBindingSource;
        public FrontEnd()
        {
            InitializeComponent();
            CartList = new List<GetAllProductDtos>();
            IContainer Container = AutoFac.Inject();
            IProductServices p = Container.Resolve<IProductServices>();

            size = (p.All_product_sum() / 9) + 1;
            currentPage = 1;

        }


        private void proTab_Click(object sender, EventArgs e)
        {



        }

        private void AddToCartButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Tag is GetAllProductDtos item)
                {
                    CartList.Add(item);

                }
            }
        }

        private void FrontEnd_Load(object sender, EventArgs e)
        {
            loadElements(1);
        }

        private void loadElements(int PageNum)
        {
            var Container = AutoFac.Inject();
            IProductServices productservice = Container.Resolve<IProductServices>();
            foreach (var item in productservice.GetPagination(9, PageNum))
            {
                GroupBox g1 = new GroupBox();
                g1.Size = new Size(200, 100);
                g1.Padding = new Padding(20);
                g1.BackColor = Color.White;

                Label label1 = new Label();
                label1.Text = item.UnitPrice.ToString();
                label1.Location = new Point(10, 20); // Set location within the GroupBox

                Label label2 = new Label();
                label2.Text = item.Name;
                label2.Location = new Point(10, 40);

                // Create an "Add to Cart" button
                Button button1 = new Button();
                button1.Width = 178;
                button1.Text = " Add To Cart ";
                button1.Location = new Point(10, 60);
                button1.Tag = item;

                // Add event handler for the button click
                button1.Click += AddToCartButton_Click;

                // Add the controls to the GroupBox
                g1.Controls.Add(label1);
                g1.Controls.Add(label2);
                g1.Controls.Add(button1);

                // Add the GroupBox to the form or flow layout panel
                flowProLayout.Controls.Add(g1);
            }
        }


        private void LoadOneElement(string nama)
        {
            var Container = AutoFac.Inject();
            IProductServices productservice = Container.Resolve<IProductServices>();
            var item = productservice.Search(nama);

            if (item != null)
            {
                GroupBox g1 = new GroupBox();
                g1.Size = new Size(200, 100);
                g1.Padding = new Padding(20);
                g1.BackColor = Color.White;

                Label label1 = new Label();
                label1.Text = item.UnitPrice.ToString();
                label1.Location = new Point(10, 20); // Set location within the GroupBox

                Label label2 = new Label();
                label2.Text = item.Name;
                label2.Location = new Point(10, 40);

                // Create an "Add to Cart" button
                Button button1 = new Button();
                button1.Width = 178;
                button1.Text = " Add To Cart ";
                button1.Location = new Point(10, 60);
                button1.Tag = item;

                // Add event handler for the button click
                button1.Click += AddToCartButton_Click;

                // Add the controls to the GroupBox
                g1.Controls.Add(label1);
                g1.Controls.Add(label2);
                g1.Controls.Add(button1);

                // Add the GroupBox to the form or flow layout panel
                flowProLayout.Controls.Add(g1);

            }

        }

        private void Front_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Front.SelectedIndex == 1) // Adjust index as needed
            {
                // Refresh the data source of the DataGridView to show the updated CartList
                CardGrid.DataSource = null; // Clear the previous binding
                CardGrid.DataSource = CartList; // Set the new data source
                CardGrid.Refresh(); // Refresh to apply the new data
            }
        }


        private void Update_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (PrdBindingSource == null)
            {
                PrdBindingSource = new BindingSource(CartList, "");
                bindingNavigator = new BindingNavigator(PrdBindingSource);
                UpdateProName.Controls.Add(bindingNavigator);
                bindingNavigator.Dock = DockStyle.Top;

                //simple Data Binding 
                ProUpdate.DataSource = CartList;  // not carTlist but all product 
                ProUpdate.DisplayMember = "Name";
                ProUpdate.ValueMember = "Name";

                ProUpdate.DataBindings.Add("SelectedValue", PrdBindingSource, "Name");
                ProPrice.DataBindings.Add("Text", PrdBindingSource, "UnitPrice");

            }

        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            decimal? price = 0;
            foreach (var item in CartList)
            {
                if (price != null)
                    price += item.UnitPrice;
            }
            DialogResult massege = MessageBox.Show($"Your Bill = {price}$ ");

            if (massege == DialogResult.OK)
            {
                // Insert the order 

            }
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            if (currentPage >= 1 && currentPage < size)
            {
                flowProLayout.Controls.Clear();
                currentPage++;
                loadElements(currentPage);
            }
        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                flowProLayout.Controls.Clear();
                currentPage--;
                loadElements(currentPage);
            }
        }

        private void searhBtn_Click(object sender, EventArgs e)
        {
            if(SearchText.Text != string.Empty) { 
            string name = SearchText.Text;
            flowProLayout.Controls.Clear();
            LoadOneElement(name);
            }
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchText.Text))
            {
                flowProLayout.Controls.Clear();
                loadElements(1);
            }
        }
    }
}