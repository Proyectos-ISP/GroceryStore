using Data.Object;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software
{
    public partial class addEdit : Form
    {

        private string idProduct;
        ProductsRepo product = new ProductsRepo();
        public addEdit(string? idProduct)
        {
            InitializeComponent();
            this.idProduct = idProduct;
            if (idProduct != null)
            {
                loadProducts();
                btnSend.Text = "Editar";
            }
            else
            {
                btnSend.Text = "Agregar";
                btnExit.Visible = false;
            }
        }
        private async void loadProducts()
        {
            Product? NewProduct = await product.getId(this.idProduct);
            if (NewProduct != null)
            {
                txtName.Text = NewProduct.Name;
                txtCategory.Text = NewProduct.Category;
                txtDescription.Text = NewProduct.Description;
                txtQuantity.Value = NewProduct.Quantity;
                txtPrice.Value = (decimal)NewProduct.Price;
            }
            else
                MessageBox.Show("[ERROR] No se encontro el producto");
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (idProduct != null)
            {
                await product.Update(this.idProduct, txtName.Text, txtCategory.Text, txtDescription.Text, (int)txtQuantity.Value, (float)txtPrice.Value);
            }
            else
            {
                await product.add(txtName.Text, txtCategory.Text, txtDescription.Text, (int)txtQuantity.Value, (float)txtPrice.Value);
            }
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
