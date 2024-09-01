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

    public partial class FrontEnd : Form
    {
        Products products;
        Cart cart;
        About about;
        customerLogin log;
        public int CustomerID {  get; set; }
        public FrontEnd()
        {
             products = new Products();
             cart = new Cart();
             about = new About();
             log = new customerLogin();
            InitializeComponent();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
        
                PanelMain.Controls.Clear();
                products.Visible = true;  // Ensure it's set to visible
                PanelMain.Controls.Add(products);
                products.Show();

         

        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(cart);
            cart.Dock = DockStyle.Fill;
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(about);
            about.Dock = DockStyle.Fill;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(log);
            log.Dock = DockStyle.Fill;
        }
    }
}
