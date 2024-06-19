namespace MediaBazaarSemester2Retake
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRefreshProducts = new Button(); // Added this line
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            txtStock = new TextBox();
            label5 = new Label();
            txtSellingPrice = new TextBox();
            label4 = new Label();
            txtBuyingPrice = new TextBox();
            label3 = new Label();
            txtCategory = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtProductId = new TextBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(18, 18);
            tabControl1.Margin = new Padding(4, 4, 4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1164, 639);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRefreshProducts); // Added this line
            tabPage1.Controls.Add(btnDeleteProduct);
            tabPage1.Controls.Add(btnUpdateProduct);
            tabPage1.Controls.Add(btnAddProduct);
            tabPage1.Controls.Add(txtStock);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtSellingPrice);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtBuyingPrice);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtCategory);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtProductId);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Margin = new Padding(4, 4, 4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 4, 4, 4);
            tabPage1.Size = new Size(1156, 596);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Products";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefreshProducts
            // 
            btnRefreshProducts.Location = new Point(310, 380);
            btnRefreshProducts.Margin = new Padding(4, 4, 4, 4);
            btnRefreshProducts.Name = "btnRefreshProducts";
            btnRefreshProducts.Size = new Size(141, 44);
            btnRefreshProducts.TabIndex = 13;
            btnRefreshProducts.Text = "Refresh";
            btnRefreshProducts.UseVisualStyleBackColor = true;
            btnRefreshProducts.Click += btnRefreshProducts_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(794, 380);
            btnDeleteProduct.Margin = new Padding(4, 4, 4, 4);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(141, 44);
            btnDeleteProduct.TabIndex = 12;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(628, 380);
            btnUpdateProduct.Margin = new Padding(4, 4, 4, 4);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(141, 44);
            btnUpdateProduct.TabIndex = 11;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(462, 380);
            btnAddProduct.Margin = new Padding(4, 4, 4, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(141, 44);
            btnAddProduct.TabIndex = 10;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(194, 273);
            txtStock.Margin = new Padding(4, 4, 4, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(889, 35);
            txtStock.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 278);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 30);
            label5.TabIndex = 8;
            label5.Text = "Stock";
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(194, 210);
            txtSellingPrice.Margin = new Padding(4, 4, 4, 4);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(889, 35);
            txtSellingPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 214);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 30);
            label4.TabIndex = 6;
            label4.Text = "Selling Price";
            // 
            // txtBuyingPrice
            // 
            txtBuyingPrice.Location = new Point(194, 147);
            txtBuyingPrice.Margin = new Padding(4, 4, 4, 4);
            txtBuyingPrice.Name = "txtBuyingPrice";
            txtBuyingPrice.Size = new Size(889, 35);
            txtBuyingPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 4;
            label3.Text = "Buying Price";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(194, 84);
            txtCategory.Margin = new Padding(4, 4, 4, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(889, 35);
            txtCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 21);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(889, 35);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(194, 327);
            txtProductId.Margin = new Padding(4, 4, 4, 4);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(889, 35);
            txtProductId.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 332);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 30);
            label6.TabIndex = 15;
            label6.Text = "Product ID";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Margin = new Padding(4, 4, 4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 4, 4, 4);
            tabPage2.Size = new Size(1156, 596);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Product List";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 9);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1134, 572);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 675);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ProductForm";
            Text = "Product Management";
            Load += ProductForm_Load; // Added this line
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRefreshProducts; // Added this line
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuyingPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}