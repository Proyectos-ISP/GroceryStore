using Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software
{
    public partial class ListProducts : Form
    {

        ProductsRepo product = new ProductsRepo();
        public ListProducts()
        {
            InitializeComponent();
            loadProducts();
        }

        private async void loadProducts()
        {
            dataProductsView.DataSource = await product.get();
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            string? idProduct = (string)dataProductsView.CurrentRow.Cells[0].Value;

            addEdit addEditView = new addEdit();
            addEditView.TopLevel = true;
            addEditView.ShowDialog();

            loadProducts();

        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            string? idProduct = (string)dataProductsView.CurrentRow.Cells[0].Value;

            string? nameProduct = (string)dataProductsView.CurrentRow.Cells[1].Value;

            DialogResult answer = MessageBox.Show($"Esta seguro de borrar el articulo: {nameProduct}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                await product.Remove(idProduct);
                loadProducts();
            }
        }
    }
}
