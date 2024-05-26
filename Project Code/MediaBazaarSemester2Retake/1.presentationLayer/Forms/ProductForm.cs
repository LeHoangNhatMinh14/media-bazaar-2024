using System;
using System.Windows.Forms;

namespace MediaBazaarSemester2Retake
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        // Event handler for adding a product
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Add product logic
            // Example: AddProduct(txtName.Text, txtCategory.Text, decimal.Parse(txtBuyingPrice.Text), decimal.Parse(txtSellingPrice.Text), int.Parse(txtStock.Text));
        }

        // Event handler for updating a product
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            // Update product logic
            // Example: UpdateProduct(productId, txtName.Text, txtCategory.Text, decimal.Parse(txtBuyingPrice.Text), decimal.Parse(txtSellingPrice.Text), int.Parse(txtStock.Text));
        }

        // Event handler for deleting a product
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Delete product logic
            // Example: DeleteProduct(productId);
        }

        // Load event to populate the form with product data
        private void ProductForm_Load(object sender, EventArgs e)
        {
            // Load products into DataGridView or other controls
            // Example: LoadProducts();
        }
    }
}
