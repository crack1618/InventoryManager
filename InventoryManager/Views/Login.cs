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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usr = txtUser.Text;
            string pass = txtPass.Text;
            bdManager bdm = new bdManager();
            if(bdm.validateUser(usr, pass))
            {
                MessageBox.Show("Bienvenid@!!");
                var thread = new System.Threading.Thread(new System.Threading.ThreadStart(RunPrincipal));
                this.Close();
                thread.SetApartmentState(System.Threading.ApartmentState.STA);
                thread.Start();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto.");
            }
            
        }

        private void RunPrincipal()
        {
            MainMenu main = new MainMenu();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool validateLogin()
        {

            return true;
        }

    }
}
