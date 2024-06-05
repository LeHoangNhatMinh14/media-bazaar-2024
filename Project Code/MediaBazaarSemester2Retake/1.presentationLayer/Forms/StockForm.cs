using DAL;
using System;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake._1.presentationLayer.Forms
{
    public partial class StockForm : Form
    {
        private StockRepo stockRepo;

        public StockForm()
        {
            InitializeComponent();
            stockRepo = new StockRepo(); // Initialize the StockRepo
        }

        // Event handler for adding stock
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(txtProductId.Text);
                int quantity = int.Parse(txtStockQuantity.Text);
                stockRepo.AddStock(productId, quantity);
                MessageBox.Show("Stock added successfully!");
                LoadStock(); // Refresh the stock list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding stock: {ex.Message}");
            }
        }

        // Event handler for updating stock
        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(txtProductId.Text);
                int quantity = int.Parse(txtStockQuantity.Text);
                stockRepo.ReduceStock(productId, quantity);
                MessageBox.Show("Stock updated successfully!");
                LoadStock(); // Refresh the stock list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating stock: {ex.Message}");
            }
        }

        // Load event to populate the form with stock data
        private void StockForm_Load(object sender, EventArgs e)
        {
            LoadStock(); // Load stock into DataGridView or other controls
        }

        private void LoadStock()
        {
            try
            {
                var stockList = stockRepo.GetAllStock();
                dataGridView1.DataSource = stockList; // Assuming you have a DataGridView named dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock: {ex.Message}");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Handle tab page click if needed
        }
    }
}