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
    public partial class MainMenu : Form
    {
        private string producto;
        public MainMenu()
        {
            InitializeComponent();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RunVerProducto()
        {
            VerProducto vp = new VerProducto(producto);
            vp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto = "camisa";
            redirect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            producto = "pantalon-hombre";
            redirect();
        }
        
        private void redirect()
        {
            var thread = new System.Threading.Thread(new System.Threading.ThreadStart(RunVerProducto));
            this.Close();
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            producto = "accesorio-hombre";
            redirect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            producto = "saco";
            redirect();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            producto = "blusa";
            redirect();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            producto = "pantalon-mujer";
            redirect();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            producto = "accesorio-mujer";
            redirect();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            producto = "vestido";
            redirect();
        }
    }
}
