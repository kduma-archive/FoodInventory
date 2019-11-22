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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dbDataSet.Products);
            // TODO: This line of code loads data into the 'dbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dbDataSet.Products);

        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
            FoodInventory.ProductsEditViewDialog productsEditViewDialog = FoodInventory.ProductsEditViewDialog.Instance(this.productsBindingSource);
            productsEditViewDialog.ShowDialog();

        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            FoodInventory.ProductsSummaryViewDialog productsSummaryViewDialog = FoodInventory.ProductsSummaryViewDialog.Instance(this.productsBindingSource);
            productsSummaryViewDialog.ShowDialog();

        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {

        }
    }
}