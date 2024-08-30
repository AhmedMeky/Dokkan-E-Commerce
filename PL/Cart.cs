using Eldokkan.Dto.Product;
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
    public partial class Cart : UserControl
    {
        public List<GetAllProductDtos> products = new List<GetAllProductDtos>();
        public Cart()
        {
            InitializeComponent();
                
        }

        private void Cart_Load(object sender, EventArgs e)
        {
                   
            foreach (var product in products)
            {
                CartList.Items.Add(product.Name);
            }
        }
    }
}
