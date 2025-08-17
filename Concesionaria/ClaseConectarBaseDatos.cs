using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//Se necesita instalar el paquete NuGet MySql.Data para net6.0 --- instalar-Package MySql.Data -Version 8.0.33

namespace Concesionaria
{
    internal class ClaseConectarBaseDatos
    {
        public MySqlConnection conexion;

        public ClaseConectarBaseDatos(string Conexion) 
        { 
            conexion = new MySqlConnection(Conexion);
        }

        public void AbrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public DataTable ObtenerTabla(string Orden)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter(Orden, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

        public void InsertarDato(string Orden)
        {
            MySqlCommand ComandoDeInsercion = new MySqlCommand(Orden,conexion); 
            ComandoDeInsercion.ExecuteNonQuery();
        }
    }
        
}
