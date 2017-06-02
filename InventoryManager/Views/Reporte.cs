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
            this.CenterToScreen();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProductos.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dataSetProductos.Producto);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(new System.Threading.ThreadStart(back));
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void back()
        {
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
        }

    }
}
