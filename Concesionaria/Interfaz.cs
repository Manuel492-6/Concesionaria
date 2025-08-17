namespace Concesionaria
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }
        private void Interfaz_Load(object sender, EventArgs e)
        {
        }
        private void btnSalirAplicacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Interfaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ResultadoMensaje = MessageBox.Show("Estas seguro de salir de la aplicacion: ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ResultadoMensaje != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.ShowDialog();
            this.Show();
        }
    }
}
