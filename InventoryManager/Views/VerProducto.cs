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
        bdManager bdm;
        public VerProducto(string producto)
        {
            // productos: "camisa","blusa","pantalon-hombre","pantalon-mujer","accesirio-hombre","accesorio-mujer","saco","vestido"
            InitializeComponent();
            product = producto;
            bdm = new bdManager();
        }

        private void VerProducto_Load(object sender, EventArgs e)
        {
            label1.Text = product;
            float totalE = bdm.totalPrecio(product, "xibit");
            float totalA = bdm.totalPrecio(product, "stock");
            label2.Text = "Prendas en exhibición: " + bdm.total(product, "xibit");
            label3.Text = "Prendas en almacén: " + bdm.total(product, "stock");
            label4.Text = "Precio total en exhibición: " + totalE;
            label5.Text = "Precio total en almacén: " + totalA;
            label6.Text = "Precio total: " + (totalA+totalE);
            label7.Text = "Número de prendas distintas: " + bdm.prendasDiferentestipos(product);
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
