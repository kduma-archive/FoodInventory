namespace FoodInventory
{
    partial class ProductsEditViewDialog
    {
        public static ProductsEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new FoodInventory.ProductsEditViewDialog();
                defaultInstance.productsBindingSource.DataSource = bindingSource;
            }
            defaultInstance.nameTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.productsBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static ProductsEditViewDialog defaultInstance;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label validLabel;
            System.Windows.Forms.Label locationLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.validTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            nameLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            validLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(4, 2);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(232, 21);
            nameLabel.Text = "name:";
            // 
            // barcodeLabel
            // 
            barcodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            barcodeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            barcodeLabel.Location = new System.Drawing.Point(4, 44);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(232, 21);
            barcodeLabel.Text = "barcode:";
            // 
            // countryLabel
            // 
            countryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            countryLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            countryLabel.Location = new System.Drawing.Point(4, 86);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(232, 21);
            countryLabel.Text = "country:";
            // 
            // validLabel
            // 
            validLabel.Dock = System.Windows.Forms.DockStyle.Top;
            validLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            validLabel.Location = new System.Drawing.Point(4, 128);
            validLabel.Name = "validLabel";
            validLabel.Size = new System.Drawing.Size(232, 21);
            validLabel.Text = "valid:";
            // 
            // locationLabel
            // 
            locationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            locationLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            locationLabel.Location = new System.Drawing.Point(4, 170);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(232, 21);
            locationLabel.Text = "location:";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = typeof(FoodInventory.dbDataSet);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "name", true));
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(4, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "barcode", true));
            this.barcodeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodeTextBox.Location = new System.Drawing.Point(4, 65);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(232, 21);
            this.barcodeTextBox.TabIndex = 3;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "country", true));
            this.countryTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryTextBox.Location = new System.Drawing.Point(4, 107);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(232, 21);
            this.countryTextBox.TabIndex = 5;
            // 
            // validTextBox
            // 
            this.validTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "valid", true));
            this.validTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.validTextBox.Location = new System.Drawing.Point(4, 149);
            this.validTextBox.Name = "validTextBox";
            this.validTextBox.Size = new System.Drawing.Size(232, 21);
            this.validTextBox.TabIndex = 7;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "location", true));
            this.locationTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationTextBox.Location = new System.Drawing.Point(4, 191);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(232, 21);
            this.locationTextBox.TabIndex = 9;
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(4, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(232, 2);
            // 
            // leftBorderPanel
            // 
            this.leftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBorderPanel.Name = "leftBorderPanel";
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 268);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(236, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 268);
            // 
            // ProductsEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.validTextBox);
            this.Controls.Add(validLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ProductsEditViewDialog";
            this.Text = "ProductsEditViewDialog";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ProductsEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox validTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}