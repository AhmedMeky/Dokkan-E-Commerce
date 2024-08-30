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

    namespace PL
    {
        public partial class Products : UserControl
        {
            Cart c;
           

            public Products()
            {
                c = new Cart();
                InitializeComponent();
            }



            private void Products_Load(object sender, EventArgs e)
            {

                var Container = AutoFac.Inject();
                IProductServices productservice = Container.Resolve<IProductServices>();
                //ProductGrid.DataSource = productservice.GetPagination(10, 1);

                foreach(var item in productservice.GetPagination(10, 1))
                {
                GroupBox g1 = new GroupBox();
                g1.Size = new Size(200, 100); 
                g1.Padding = new Padding(10); 
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
                flowLayoutPanel1.Controls.Add(g1);


            }




            }

        private void AddToCartButton_Click(object? sender, EventArgs e)
        {
            if(sender is Button button)
            {
                if(button.Tag is GetAllProductDtos item)
                {
                    c.products.Add(item);

                }
            }
        }

        private void ProductPanel_Paint(object sender, PaintEventArgs e)
            {

            }
        }
    }
