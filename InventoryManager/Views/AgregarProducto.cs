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
    public partial class AgregarProducto : Form
    {
        private bdManager bdm;
        private string productoActual;

        public AgregarProducto(string producto)
        {
            bdm = new bdManager();
            InitializeComponent();
            lblCode.Text = ""+bdm.getNextCode();
            this.productoActual = producto;
            this.CenterToScreen();
        }

        public bool ValidateFields()
        {
            string warningMessages = "";
            if (String.IsNullOrEmpty(txtDesc.Text)) warningMessages += "- La descripción del producto no puede estar vacía!!\n";
            if (numPrice.Value == 0) warningMessages += "- Indique un precio para el producto.\n";
            if (numStock.Value == 0 && numExhib.Value == 0) warningMessages += "- El total de productos no puede ser 0\n\tIndique una cantidad en bodega o exhibición.\n";
            if(warningMessages != "")
            {
                MessageBox.Show(warningMessages);
                return false;
            }
            return true;
        }

        public bool GuardarProducto()
        {
            string gender,description,type; 
            decimal price; 
            int stock, xibit;
            switch (productoActual)
            {
                case "camisa":
                    gender = "H";
                    type = "camisa";
                    break;
                case "blusa":
                    gender = "M";
                    type = "blusa";
                    break;
                case "pantalon-hombre":
                    gender = "H";
                    type = "pantalon";
                    break;
                case "pantalon-mujer":
                    gender = "M";
                    type = "pantalon";
                    break;
                case "accesorio-hombre":
                    gender = "H";
                    type = "accesorio";
                    break;
                case "accesorio-mujer":
                    gender = "M";
                    type = "accesorio";
                    break;
                case "saco":
                    gender = "H";
                    type = "saco";
                    break;
                case "vestido":
                    gender = "M";
                    type = "vestido";
                    break;
                default:
                    gender = "H";
                    type = "camisa";
                    break;
            }
            price = numPrice.Value;
            stock = (int)numStock.Value;
            xibit = (int)numExhib.Value;
            description = txtDesc.Text;
            if(bdm.InsertProduct(gender, type, price, stock, xibit, description))
            {
                MessageBox.Show("El producto se agregó correctamente!");
                return true;
            }
            return false;
        }

        private void redirect()
        {
            var thread = new System.Threading.Thread(new System.Threading.ThreadStart(RunVerProducto));
            this.Close();
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
        }

        private void RunVerProducto()
        {
            VerProducto vp = new VerProducto(productoActual);
            vp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateFields())
            {
                if(GuardarProducto())
                {
                    redirect();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            redirect();
        }
    }
}
