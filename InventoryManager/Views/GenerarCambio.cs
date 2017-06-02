using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager.Views
{
    public partial class GenerarCambio : Form
    {
        public GenerarCambio(string producto)
        {
            InitializeComponent();
            typeToolStripTextBox.Text = producto;
            lblproducto.Text = producto;
        }

        private void GenerarCambio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iMDBProductoDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.iMDBProductoDataSet.Producto);

        }

        private void searchChangeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.SearchChange(this.iMDBProductoDataSet.Producto, this.inputToolStripTextBox.Text, this.typeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchChangeToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.SearchChange(this.iMDBProductoDataSet.Producto, inputToolStripTextBox.Text, typeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
