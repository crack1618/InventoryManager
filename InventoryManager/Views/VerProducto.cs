using InventoryManager.DataAccess;
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
    public partial class VerProducto : Form
    {

        string product;
        public VerProducto(string producto)
        {
            // productos: "camisa","blusa","pantalon-hombre","pantalon-mujer","accesirio-hombre","accesorio-mujer","saco","vestido"
            InitializeComponent();
            product = producto;
        }

        private void VerProducto_Load(object sender, EventArgs e)
        {
           
            label1.Text = product;
            bdManager dbm = new bdManager();
            textBox1.Text = "Descripción: " + dbm.description(product);
            textBox1.ReadOnly = true;
            Bitmap image = new Bitmap(InventoryManager.Properties.Resources.d);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
