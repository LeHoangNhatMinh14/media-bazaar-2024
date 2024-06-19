using BusinessLogicLayer.Class;
using DAL;
using System;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake
{
    public partial class ProductForm : Form
    {
        private ProductRepo productRepo;

        public ProductForm()
        {
            InitializeComponent();
            productRepo = new ProductRepo(); // Initialize the ProductRepo
        }

        // Event handler for adding a product
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    Name = txtName.Text,
                    Category = txtCategory.Text,
                    BuyingPrice = decimal.Parse(txtBuyingPrice.Text),
                    SellingPrice = decimal.Parse(txtSellingPrice.Text),
                    Stock = int.Parse(txtStock.Text)
                };
                productRepo.AddProduct(product);
                MessageBox.Show("Product added successfully!");
                LoadProducts(); // Refresh the product list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}");
            }
        }

        // Event handler for updating a product
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(txtProductId.Text); // ProductId is now correctly referenced
                Product product = new Product
                {
                    ProductId = productId,
                    Name = txtName.Text,
                    Category = txtCategory.Text,
                    BuyingPrice = decimal.Parse(txtBuyingPrice.Text),
                    SellingPrice = decimal.Parse(txtSellingPrice.Text),
                    Stock = int.Parse(txtStock.Text)
                };
                productRepo.UpdateProduct(product);
                MessageBox.Show("Product updated successfully!");
                LoadProducts(); // Refresh the product list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        // Event handler for deleting a product
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(txtProductId.Text); // ProductId is now correctly referenced
                productRepo.DeleteProduct(productId);
                MessageBox.Show("Product deleted successfully!");
                LoadProducts(); // Refresh the product list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}");
            }
        }

        // Load event to populate the form with product data
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts(); // Load products into DataGridView or other controls
        }

        // Event handler for refreshing the product list
        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            LoadProducts(); // Refresh the product list
        }

        private void LoadProducts()
        {
            try
            {
                var products = productRepo.GetAllProducts();
                dataGridView1.DataSource = products; // Assuming you have a DataGridView named dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }
    }
}