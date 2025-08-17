using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionaria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
        private void btnRegresarInterfaz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrarInventario_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InventarioAutos inventarioAutos = new InventarioAutos();
            inventarioAutos.ShowDialog();
            this.Show();
        }
    }
}
