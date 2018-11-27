using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOpcionalAcces
{
	class Alumnos
	{
		private int dniAlumno;
		private string nombreAlumno;
		private string direccionAlumno;
		private int telefono;
		private string fechaNacimiento;

		public Alumnos()
		{

		}

		public Alumnos(int dniAlumno, string nombreAlumno, string direccionAlumno, int telefono, string fechaNacimiento)
		{
			this.dniAlumno = dniAlumno;
			this.nombreAlumno = nombreAlumno;
			this.direccionAlumno = direccionAlumno;
			this.telefono = telefono;
			this.fechaNacimiento = fechaNacimiento;
		}

		public int DniAlumno { get => dniAlumno; set => dniAlumno = value; }
		public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
		public string DireccionAlumno { get => direccionAlumno; set => direccionAlumno = value; }
		public int Telefono { get => telefono; set => telefono = value; }
		public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
	}
}
