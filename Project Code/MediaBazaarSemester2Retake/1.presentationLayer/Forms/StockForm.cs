using System;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }

        // Event handler for adding stock
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            // Add stock logic
            // Example: AddStock(int.Parse(txtProductId.Text), int.Parse(txtStockQuantity.Text));
        }

        // Event handler for updating stock
        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            // Update stock logic
            // Example: UpdateStock(int.Parse(txtProductId.Text), int.Parse(txtStockQuantity.Text));
        }

        // Load event to populate the form with stock data
        private void StockForm_Load(object sender, EventArgs e)
        {
            // Load stock into DataGridView or other controls
            // Example: LoadStock();
        }
    }
}
