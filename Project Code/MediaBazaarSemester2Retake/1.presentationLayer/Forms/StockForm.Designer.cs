namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    partial class StockForm
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
            btnUpdateStock = new Button();
            btnAddStock = new Button();
            txtStockQuantity = new TextBox();
            label2 = new Label();
            txtProductId = new TextBox();
            label1 = new Label();
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
            tabPage1.Controls.Add(btnUpdateStock);
            tabPage1.Controls.Add(btnAddStock);
            tabPage1.Controls.Add(txtStockQuantity);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtProductId);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Margin = new Padding(4, 4, 4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 4, 4, 4);
            tabPage1.Size = new Size(1156, 596);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Stock";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(628, 380);
            btnUpdateStock.Margin = new Padding(4, 4, 4, 4);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(141, 44);
            btnUpdateStock.TabIndex = 12;
            btnUpdateStock.Text = "Update";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // btnAddStock
            // 
            btnAddStock.Location = new Point(462, 380);
            btnAddStock.Margin = new Padding(4, 4, 4, 4);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(141, 44);
            btnAddStock.TabIndex = 11;
            btnAddStock.Text = "Add";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(194, 84);
            txtStockQuantity.Margin = new Padding(4, 4, 4, 4);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(889, 35);
            txtStockQuantity.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 3;
            label2.Text = "Stock Quantity";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(194, 21);
            txtProductId.Margin = new Padding(4, 4, 4, 4);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(889, 35);
            txtProductId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 1;
            label1.Text = "Product ID";
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
            tabPage2.Text = "Stock List";
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
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 675);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StockForm";
            Text = "Stock Management";
            Load += StockForm_Load;
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
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}