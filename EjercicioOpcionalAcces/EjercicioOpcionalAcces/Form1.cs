using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioOpcionalAcces
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'escuelaDataSet.Asignatura' Puede moverla o quitarla según sea necesario.
			this.asignaturaTableAdapter.Fill(this.escuelaDataSet.Asignatura);
			// TODO: esta línea de código carga datos en la tabla 'escuelaDataSet.Profesores' Puede moverla o quitarla según sea necesario.
			this.profesoresTableAdapter.Fill(this.escuelaDataSet.Profesores);
			// TODO: esta línea de código carga datos en la tabla 'escuelaDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
			this.alumnosTableAdapter.Fill(this.escuelaDataSet.Alumnos);
			
		}

		private void btnAceptarAlumno_Click(object sender, EventArgs e)
		{
			if (escuelaDataSet.HasChanges())
			{
				this.alumnosTableAdapter.Update(this.escuelaDataSet);
				MessageBox.Show("Se han realizado los cambios.");
			}
		}

		private void btnAceptarProfesor_Click(object sender, EventArgs e)
		{
			if (escuelaDataSet.HasChanges())
			{
				this.profesoresTableAdapter.Update(this.escuelaDataSet);
				MessageBox.Show("Se han realizado los cambios.");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (escuelaDataSet.HasChanges())
			{
				this.asignaturaTableAdapter.Update(this.escuelaDataSet);
				MessageBox.Show("Se han realizado los cambios.");
			}
		}
	}
}
