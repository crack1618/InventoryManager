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
    public partial class GenerarCambio : Form
    {
        string type;
        string productoActual;
        bdManager bdm;
        public GenerarCambio(string producto)
        {
            productoActual = producto;
            switch (producto)
            {
                case "camisa":
                    type = "camisa";
                    break;
                case "blusa":
                    type = "blusa";
                    break;
                case "pantalon-hombre":
                    type = "pantalon";
                    break;
                case "pantalon-mujer":
                    type = "pantalon";
                    break;
                case "accesorio-hombre":
                    type = "accesorio";
                    break;
                case "accesorio-mujer":
                    type = "accesorio";
                    break;
                case "saco":
                    type = "saco";
                    break;
                case "vestido":
                    type = "vestido";
                    break;
                default:
                    type = "camisa";
                    break;
            }
            InitializeComponent();
            typeToolStripTextBox.Text = type.ToUpper();
            lblproducto.Text = type;
            bdm = new bdManager();
            this.CenterToScreen();

        }

        private bool ValidateFields()
        {
            string warningMessages = "";
            if (numericUpDown1.Value == 0) warningMessages += "- Indique una cantidad a cambiar.\n";
            if (comboBox1.SelectedItem == null) warningMessages += "- Seleccione el origen del cambio.\n";
            if (dataGridView1.SelectedCells.Count == 0) warningMessages += "- Seleccione un producto de la tabla.\n";
            if (warningMessages == "")
            {
                int rowIndx = dataGridView1.SelectedCells[0].RowIndex;
                int code = (int)(dataGridView1.Rows[rowIndx].Cells[0].Value);
                string from = (comboBox1.SelectedIndex == 0) ? "stock" : "xibit";
                int quantity = (int)numericUpDown1.Value;
                if (!bdm.ValidateQuantityInStock(code, from, quantity)) 
                    warningMessages += "* La cantidad a mover debe ser menor que la existente en " + ((from.Equals("stock"))?"bodega":"exhibición") + " .\n";
            }
            if (warningMessages != "")
            {
                MessageBox.Show(warningMessages);
                return false;
            }
            return true;
        }

        private void GenerateChange()
        {
            if (!ValidateFields()) return;
            
            int rowIndx = dataGridView1.SelectedCells[0].RowIndex;
            int code = (int)(dataGridView1.Rows[rowIndx].Cells[0].Value);
            string from = (comboBox1.SelectedIndex == 0)? "stock" : "xibit";
            int quantity = (int)numericUpDown1.Value;
            
            if(bdm.GenerateChange(code, from, quantity))
            {
                MessageBox.Show("El cambio se ha hecho correctamente");
                this.productoTableAdapter.Fill(this.iMDBProductoDataSet.Producto);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateChange();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            redirect();
        }
    }
}
