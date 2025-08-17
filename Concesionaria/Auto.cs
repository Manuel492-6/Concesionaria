using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    internal class Auto
    {
		private string strNombre;

		public string Nombre
		{
			get { return strNombre; }
			set
			{
				if (value == string.Empty)
				{
					throw new Exception("No debe estar vacio el campo nombre");
				}
				else
				{
					strNombre = value;							
				}
			}
		}

		private string strModelo;

		public string Modelo
		{
			get { return strModelo; }
			set { strModelo = value; }
		}

		private string strDescripcion;

		public string Descripcion
		{
			get { return strDescripcion; }
			set
			{
				if (value == string.Empty)
				{
					throw new Exception("No debe estar vacio el campo descripcion");
				}
				else
				{
					strDescripcion = value;
				}
			}
		}

		private double dblPrecio;

		public double Precio
		{
			get { return dblPrecio; }
			set 
			{
				if (value <= 0)
				{
					throw new Exception("No se permite valores en 0 o menores a este");
				}
				else
				{
					dblPrecio = value; 	
				}
				
			}
		}

		private string strColor;

		public string Color
		{
			get { return strColor; }
			set { strColor = value; }
		}
		private string strRutaImagen;

		public string RutaImagen
		{
			get { return strRutaImagen; }
			set 
			{	
				if(value == null)
				{
					throw new Exception("Debe agregar una imagen");
				}
				else
				{
					strRutaImagen = value; 
				}
			}
		}



	}
}
