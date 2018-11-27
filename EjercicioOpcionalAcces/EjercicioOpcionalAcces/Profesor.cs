using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOpcionalAcces
{
	class Profesor
	{
		private int dni_Profesor;
		private string nombre_Profesor;
		private string departamento;

		public Profesor()
		{

		}

		public Profesor(int dni_Profesor, string nombre_Profesor, string departamento)
		{
			this.dni_Profesor = dni_Profesor;
			this.nombre_Profesor = nombre_Profesor;
			this.departamento = departamento;
		}

		public int Dni_Profesor { get => dni_Profesor; set => dni_Profesor = value; }
		public string Nombre_Profesor { get => nombre_Profesor; set => nombre_Profesor = value; }
		public string Departamento { get => departamento; set => departamento = value; }
	}
}
