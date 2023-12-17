using BaseBackEnd.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPrograming
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            Product product=new Product();
            product.Name = nametextBox.Text;
            product.BrandName = brandnametextBox.Text;
            product.Count = int.Parse(counttextBox.Text);
            product.Price = decimal.Parse(pricetextBox.Text);
            product.IsActive = isactivecheckBox.Checked;

        }
    }
}
