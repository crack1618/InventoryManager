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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProductos.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dataSetProductos.Producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
