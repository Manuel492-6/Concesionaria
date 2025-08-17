using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Concesionaria
{
    public partial class InventarioAutos : Form
    {
        static ClaseConectarBaseDatos conectar = new ClaseConectarBaseDatos("Server=localhost;Database=concesionaria;Uid=root;Pwd=;");
        public InventarioAutos()
        {
            InitializeComponent();
        }

        private void InventarioAutos_Load(object sender, EventArgs e)
        {
            cboModelo.SelectedIndex = 0;
            cboColorAuto.SelectedIndex = 0;
            dgtListaAutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtListaAutos.ReadOnly = true;
            dgtListaAutos.AllowUserToAddRows = false;
            dgtListaAutos.AllowUserToDeleteRows = false;
            dgtListaAutos.MultiSelect = false;
            dgtListaAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            conectar.AbrirConexion();
            ConectarDatosConDGV();;
        }

        public string CargarFoto()
        {
            string strNombreArchivo = "";
            OpenFileDialog miArchivoFoto = new OpenFileDialog();
            miArchivoFoto.Title = "Seleccione la imagen que desea cargar";
            //miArchivoFoto.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            miArchivoFoto.Filter = "All files (*.*)|*.*";
            //miArchivoFoto.InitialDirectory = "C:\\Users\\DELL\\Desktop\\concesionaria\\Concesionaria\\Concesionaria\\Imagenes\\InicioImagenes";
            miArchivoFoto.InitialDirectory = "Imagenes\\InicioImagenes";
            if (miArchivoFoto.ShowDialog() == DialogResult.OK)
            {
                strNombreArchivo = miArchivoFoto.FileName;
                return strNombreArchivo;
            }
            else return null;
        }
        private void MostrarImagen(string strNombreArchivo)
        {
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            //picFoto.Image = (Image)miImagen;
            picFoto.ImageLocation = strNombreArchivo;
            picFoto.Refresh();
        }

        private void ConectarDatosConDGV()
        {
            dgtListaAutos.DataSource = conectar.ObtenerTabla("Select * From auto");
        }

        private void dgtListaAutos_Click(object sender, EventArgs e)
        {
            DataGridViewRow FilaSeleccionada = new DataGridViewRow();
            FilaSeleccionada = dgtListaAutos.CurrentRow;
            if (FilaSeleccionada != null)
            {
                lblNombre.Visible = true;
                lblModelo.Visible = true;
                richDescripcion.Visible = true;
                richDescripcion.BorderStyle = BorderStyle.None;
                lblPrecio.Visible = true;
                lblColor.Visible = true;
                lblNombre.Text = FilaSeleccionada.Cells[1].Value.ToString();
                lblModelo.Text = FilaSeleccionada.Cells[2].Value.ToString();
                richDescripcion.Text = FilaSeleccionada.Cells[3].Value.ToString();
                lblPrecio.Text = Convert.ToDouble(FilaSeleccionada.Cells[4].Value).ToString("C");
                lblColor.Text = FilaSeleccionada.Cells[5].Value.ToString();
                if (FilaSeleccionada.Cells[6].Value != null)
                {
                    picFotoVisualizacion.SizeMode = PictureBoxSizeMode.StretchImage;
                    picFotoVisualizacion.ImageLocation = FilaSeleccionada.Cells[6].Value.ToString().Replace("/", @"\");
                    picFotoVisualizacion.Refresh();
                    
                }
                else
                {
                    picFotoVisualizacion.Image = null;
                    picFotoVisualizacion.ImageLocation = null;
                }
            }
        }

        private void btnCargarImagen_Click_1(object sender, EventArgs e)
        {
            string strNombreArchivo = CargarFoto();
            if (strNombreArchivo != null)
                MostrarImagen(strNombreArchivo);
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            conectar.CerrarConexion();
        }

        private void btnAgregarAuto_Click_1(object sender, EventArgs e)
        {
            try
            {
                Auto auto = new Auto
                {
                    Nombre = txtNombreAuto.Text,
                    Modelo = cboModelo.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = (txtPrecioAuto.Text == string.Empty) ? throw new Exception("El campo esta vacio") : Convert.ToDouble(txtPrecioAuto.Text),
                    Color = cboColorAuto.Text,
                    RutaImagen = picFoto.ImageLocation.Replace(@"\", "/")
                };
                auto.RutaImagen = RecortarRuta(auto.RutaImagen);
                string Orden = $"INSERT INTO auto (Nombre, Modelo, Descripcion, Precio, Color, RutaImagen ) VALUE ('{auto.Nombre}','{auto.Modelo}','{auto.Descripcion}',{auto.Precio},'{auto.Color}','{auto.RutaImagen}')";
                
                conectar.InsertarDato(Orden);
                MessageBox.Show("Auto agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarCampos();
                ConectarDatosConDGV();
            }
            catch (FormatException)
            {
                MessageBox.Show("No se permite letras en el campo PRECIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RefrescarCampos()
        {
            foreach(Control Control in TabAgregarInformacion.Controls)
            {
                switch (Control)
                {
                    case TextBox textBox:
                        textBox.Text = string.Empty;
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = 0;
                        break;
                    case PictureBox pictureBox:
                        pictureBox.ImageLocation = null;
                        pictureBox.Image = null;
                        break;
                }
            }
            txtNombreAuto.Focus();

        }

        private string RecortarRuta(string RutaImagen)
        {
            int Posicion = RutaImagen.IndexOf("Imagenes");
            RutaImagen = RutaImagen.Substring(Posicion);
            return RutaImagen;
        }
    }
}
