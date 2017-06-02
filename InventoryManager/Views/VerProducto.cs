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
            textBox1.Text = "Descripción: " + dbm.column(product, "description");
            textBox1.ReadOnly = true;
            //Bitmap image = new Bitmap(InventoryManager.Properties.Resources.d);
            string aux = dbm.column(product, "xibit");
            string aux2;
            float aux3 = 0;
            float aux4 = 0;
            if (aux == "---")
                label2.Text = "Exhibición: " + 0;
            else label2.Text = "Exhibición: " + aux;
            aux = dbm.column(product, "stock");
            if (aux == "---")
                label3.Text = "En almacén: " + 0;
            else label3.Text = "En almacén: " + aux;
            aux = dbm.column(product, "xibit");
            aux2 = dbm.column(product, "price");
            if (aux == "---" || aux2 == "---")
                aux3 = 0;
            else aux3 = float.Parse(aux2) * Int32.Parse(aux);
            label4.Text = "Total en exhibión: " + aux3;
            aux = dbm.column(product, "stock");
            if (aux == "---" || aux2 == "---")
                aux4 = 0;
            else aux4 = float.Parse(aux2) * Int32.Parse(aux);
            label5.Text = "Total en almacén: " + aux4;
            label6.Text = "Total: " + (aux3 + aux4);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(new System.Threading.ThreadStart(addProduct));
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void addProduct()
        {
            AgregarProducto ap = new AgregarProducto(product);
            ap.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(new System.Threading.ThreadStart(modifyProduct));
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void modifyProduct()
        {
            GenerarCambio gc = new GenerarCambio(product);
            gc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
