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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdateStock);
            this.tabPage1.Controls.Add(this.btnAddStock);
            this.tabPage1.Controls.Add(this.txtStockQuantity);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtProductId);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Stock";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(308, 253);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(94, 29);
            this.btnUpdateStock.TabIndex = 11;
            this.btnUpdateStock.Text = "Update";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(129, 253);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(94, 29);
            this.btnAddStock.TabIndex = 10;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Location = new System.Drawing.Point(129, 140);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(594, 27);
            this.txtStockQuantity.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stock Quantity";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(129, 56);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(594, 27);
            this.txtProductId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(756, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "StockForm";
            this.Text = "Stock Management";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
    }
}
