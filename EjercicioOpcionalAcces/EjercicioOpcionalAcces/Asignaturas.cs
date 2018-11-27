using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOpcionalAcces
{
	class Asignaturas
	{
		private int id_Asignatura;
		private string nombre;
		private int dni_Profesor;

		public Asignaturas()
		{

		}

		public Asignaturas(int id_Asignatura, string nombre, int dni_Profesor)
		{
			this.id_Asignatura = id_Asignatura;
			this.nombre = nombre;
			this.dni_Profesor = dni_Profesor;
		}

		public int Id_Asignatura { get => id_Asignatura; set => id_Asignatura = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public int Dni_Profesor { get => dni_Profesor; set => dni_Profesor = value; }
	}
}
