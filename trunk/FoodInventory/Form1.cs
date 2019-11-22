using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSM.Embedded.Decoding;

namespace FoodInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //decodeComponent1.Connect();

            decodeComponent1.DecodeMode = HSM.Embedded.Decoding.DecodeComponent.DecodeModes.Standard;
            decodeComponent1.ScanKey = HSM.Embedded.Decoding.DecodeComponent.ScanKeys.Scan;
            decodeComponent1.ScanKeyOperation = HSM.Embedded.Decoding.DecodeComponent.ScanKeyOptions.ScanBarcode;
            decodeComponent1.ScanningLightsMode = HSM.Embedded.Decoding.DecodeComponent.ScanningLightsModes.AimerOnly;

            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.Code39, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.Aztec, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.CodaBar, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.Code128, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.DataMatrix, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.EAN13, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.GS1_128, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.Int25, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.MicroPDF, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.PDF417, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.UPCA, true);
            decodeComponent1.EnableSymbology(SymbologyConfigurator.Symbologies.QR, true);
        }

        private void decodeComponent1_DecodeEvent(object sender, HSM.Embedded.Decoding.DecodeAssembly.DecodeEventArgs e)
        {
            if (e.ResultCode == DecodeAssembly.ResultCodes.Success && e.CodeId == "d")
            {
                textBoxBarCode.Text = e.Message;
            }

            if (e.ResultCode == DecodeAssembly.ResultCodes.Success && e.CodeId == "j")
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.CodeId);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dbDataSet.Products);
            serialPort1.Open();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

            var row = dbDataSet.Products.NewProductsRow();
            row.valid = dateTimePicker1.Value;
            row.country = textBoxKraj.Text;
            row.barcode = textBoxBarCode.Text;
            row.name = textBoxProduct.Text;
            row.location = textBoxLocation.Text;
            dbDataSet.Products.Rows.Add(row);
            var adapter = new dbDataSetTableAdapters.ProductsTableAdapter();
            adapter.Update(dbDataSet.Products);


            var id = "FD"+adapter.last_id();
            var expire = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
            var label = "^XA" + "\n"
                + "^XFE:FOOD_IMP.ZPLL^FS" + "\n"
                + "^FN11^FD"+textBoxProduct.Text+"^FS" + "\n"
                + "^FN12^FD" + textBoxKraj.Text + "^FS" + "\n" //origin
                + "^FN13^FD"+id+"^FS" + "\n" // bc
                + "^FN14^FD"+expire+"^FS" + "\n" //expire
                + "^XZ" + "\n";

            serialPort1.Write(label);            
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}