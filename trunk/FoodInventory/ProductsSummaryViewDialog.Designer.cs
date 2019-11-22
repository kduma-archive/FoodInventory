namespace FoodInventory
{
    partial class ProductsSummaryViewDialog
    {
        public void AttachVisibilityBindings(ControlCollection controls)
        {
            for (int i = 0; (i < controls.Count); i = (i + 1))
            {
                if ((controls[i].DataBindings["Visible"] != null))
                {
                    // Attach event handlers to auto-hide controls.
                    controls[i].DataBindings["Visible"].Format += new System.Windows.Forms.ConvertEventHandler(this.Visibility_Format);
                    controls[i].DataBindings["Visible"].DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
                }
            }

        }
    
        public void Visibility_Format(object sender, System.Windows.Forms.ConvertEventArgs e)
        {
            if ((e.Value == System.DBNull.Value))
            {
                e.Value = false;
            }
            else
            {
                e.Value = true;
            }

        }
    
        public static ProductsSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new FoodInventory.ProductsSummaryViewDialog();
                defaultInstance.productsBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.productsBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static ProductsSummaryViewDialog defaultInstance;
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label validLabel;
            System.Windows.Forms.Label locationLabel;
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.barcodeLabel1 = new System.Windows.Forms.Label();
            this.countryLabel1 = new System.Windows.Forms.Label();
            this.validLabel1 = new System.Windows.Forms.Label();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            validLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "id", true));
            idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idLabel.Location = new System.Drawing.Point(4, 2);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(232, 21);
            idLabel.Text = "id:";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = typeof(FoodInventory.dbDataSet);
            // 
            // nameLabel
            // 
            nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "name", true));
            nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(4, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(232, 21);
            nameLabel.Text = "name:";
            // 
            // barcodeLabel
            // 
            barcodeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "barcode", true));
            barcodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            barcodeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            barcodeLabel.Location = new System.Drawing.Point(4, 84);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(232, 21);
            barcodeLabel.Text = "barcode:";
            // 
            // countryLabel
            // 
            countryLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "country", true));
            countryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            countryLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            countryLabel.Location = new System.Drawing.Point(4, 125);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(232, 21);
            countryLabel.Text = "country:";
            // 
            // validLabel
            // 
            validLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "valid", true));
            validLabel.Dock = System.Windows.Forms.DockStyle.Top;
            validLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            validLabel.Location = new System.Drawing.Point(4, 166);
            validLabel.Name = "validLabel";
            validLabel.Size = new System.Drawing.Size(232, 21);
            validLabel.Text = "valid:";
            // 
            // locationLabel
            // 
            locationLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "location", true));
            locationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            locationLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            locationLabel.Location = new System.Drawing.Point(4, 207);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(232, 21);
            locationLabel.Text = "location:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.editMenuItemMenuItem);
            // 
            // editMenuItemMenuItem
            // 
            this.editMenuItemMenuItem.Text = "Edit";
            this.editMenuItemMenuItem.Click += new System.EventHandler(this.editMenuItemMenuItem_Click);
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "id", true));
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "id", true));
            this.idLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel1.Location = new System.Drawing.Point(4, 23);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "name", true));
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "name", true));
            this.nameLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel1.Location = new System.Drawing.Point(4, 64);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // barcodeLabel1
            // 
            this.barcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "barcode", true));
            this.barcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "barcode", true));
            this.barcodeLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodeLabel1.Location = new System.Drawing.Point(4, 105);
            this.barcodeLabel1.Name = "barcodeLabel1";
            this.barcodeLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // countryLabel1
            // 
            this.countryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "country", true));
            this.countryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "country", true));
            this.countryLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryLabel1.Location = new System.Drawing.Point(4, 146);
            this.countryLabel1.Name = "countryLabel1";
            this.countryLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // validLabel1
            // 
            this.validLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "valid", true));
            this.validLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "valid", true));
            this.validLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.validLabel1.Location = new System.Drawing.Point(4, 187);
            this.validLabel1.Name = "validLabel1";
            this.validLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "location", true));
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "location", true));
            this.locationLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationLabel1.Location = new System.Drawing.Point(4, 228);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(232, 20);
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
            // ProductsSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.locationLabel1);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.validLabel1);
            this.Controls.Add(validLabel);
            this.Controls.Add(this.countryLabel1);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.barcodeLabel1);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ProductsSummaryViewDialog";
            this.Text = "ProductsSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductsSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label barcodeLabel1;
        private System.Windows.Forms.Label countryLabel1;
        private System.Windows.Forms.Label validLabel1;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}