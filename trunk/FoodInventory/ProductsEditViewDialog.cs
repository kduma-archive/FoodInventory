using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FoodInventory
{
    public partial class ProductsEditViewDialog : Form
    {
        public ProductsEditViewDialog()
        {
            InitializeComponent();
        }

        private void ProductsEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.productsBindingSource.EndEdit();

        }
    }
}