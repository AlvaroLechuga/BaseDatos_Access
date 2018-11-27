namespace EjercicioOpcionalAcces
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.escuelaDataSet = new EjercicioOpcionalAcces.EscuelaDataSet();
			this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.alumnosTableAdapter = new EjercicioOpcionalAcces.EscuelaDataSetTableAdapters.AlumnosTableAdapter();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAceptarAsignatura = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dNIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.profesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.idAsignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dNIProfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.asignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.profesoresTableAdapter = new EjercicioOpcionalAcces.EscuelaDataSetTableAdapters.ProfesoresTableAdapter();
			this.asignaturaTableAdapter = new EjercicioOpcionalAcces.EscuelaDataSetTableAdapters.AsignaturaTableAdapter();
			this.btnAceptarProfesor = new System.Windows.Forms.Button();
			this.btnAceptarAlumno = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.escuelaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.btnAceptarAsignatura.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// escuelaDataSet
			// 
			this.escuelaDataSet.DataSetName = "EscuelaDataSet";
			this.escuelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// alumnosBindingSource
			// 
			this.alumnosBindingSource.DataMember = "Alumnos";
			this.alumnosBindingSource.DataSource = this.escuelaDataSet;
			// 
			// alumnosTableAdapter
			// 
			this.alumnosTableAdapter.ClearBeforeFill = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.btnAceptarAlumno);
			this.tabPage4.Controls.Add(this.dataGridView1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(542, 293);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Administrar Alumno";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNIDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fNacimientoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.alumnosBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(536, 242);
			this.dataGridView1.TabIndex = 0;
			// 
			// dNIDataGridViewTextBoxColumn
			// 
			this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
			this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
			this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			// 
			// direccionDataGridViewTextBoxColumn
			// 
			this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
			this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
			this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
			// 
			// telefonoDataGridViewTextBoxColumn
			// 
			this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
			this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
			this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
			// 
			// fNacimientoDataGridViewTextBoxColumn
			// 
			this.fNacimientoDataGridViewTextBoxColumn.DataPropertyName = "F_Nacimiento";
			this.fNacimientoDataGridViewTextBoxColumn.HeaderText = "F_Nacimiento";
			this.fNacimientoDataGridViewTextBoxColumn.Name = "fNacimientoDataGridViewTextBoxColumn";
			// 
			// btnAceptarAsignatura
			// 
			this.btnAceptarAsignatura.Controls.Add(this.tabPage4);
			this.btnAceptarAsignatura.Controls.Add(this.tabPage1);
			this.btnAceptarAsignatura.Controls.Add(this.tabPage2);
			this.btnAceptarAsignatura.Location = new System.Drawing.Point(-1, -1);
			this.btnAceptarAsignatura.Name = "btnAceptarAsignatura";
			this.btnAceptarAsignatura.SelectedIndex = 0;
			this.btnAceptarAsignatura.Size = new System.Drawing.Size(550, 319);
			this.btnAceptarAsignatura.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnAceptarProfesor);
			this.tabPage1.Controls.Add(this.dataGridView2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(542, 293);
			this.tabPage1.TabIndex = 4;
			this.tabPage1.Text = "Admistrar Profesor";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNIDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.departamentoDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.profesoresBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(536, 235);
			this.dataGridView2.TabIndex = 0;
			// 
			// dNIDataGridViewTextBoxColumn1
			// 
			this.dNIDataGridViewTextBoxColumn1.DataPropertyName = "DNI";
			this.dNIDataGridViewTextBoxColumn1.HeaderText = "DNI";
			this.dNIDataGridViewTextBoxColumn1.Name = "dNIDataGridViewTextBoxColumn1";
			// 
			// nombreDataGridViewTextBoxColumn1
			// 
			this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
			this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
			this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
			// 
			// departamentoDataGridViewTextBoxColumn
			// 
			this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
			this.departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
			this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
			// 
			// profesoresBindingSource
			// 
			this.profesoresBindingSource.DataMember = "Profesores";
			this.profesoresBindingSource.DataSource = this.escuelaDataSet;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.dataGridView3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(542, 293);
			this.tabPage2.TabIndex = 5;
			this.tabPage2.Text = "Administrar Asignatura";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsignaturaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn2,
            this.dNIProfDataGridViewTextBoxColumn});
			this.dataGridView3.DataSource = this.asignaturaBindingSource;
			this.dataGridView3.Location = new System.Drawing.Point(3, 3);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(536, 250);
			this.dataGridView3.TabIndex = 0;
			// 
			// idAsignaturaDataGridViewTextBoxColumn
			// 
			this.idAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "Id_Asignatura";
			this.idAsignaturaDataGridViewTextBoxColumn.HeaderText = "Id_Asignatura";
			this.idAsignaturaDataGridViewTextBoxColumn.Name = "idAsignaturaDataGridViewTextBoxColumn";
			// 
			// nombreDataGridViewTextBoxColumn2
			// 
			this.nombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
			this.nombreDataGridViewTextBoxColumn2.HeaderText = "Nombre";
			this.nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
			// 
			// dNIProfDataGridViewTextBoxColumn
			// 
			this.dNIProfDataGridViewTextBoxColumn.DataPropertyName = "DNI_Prof";
			this.dNIProfDataGridViewTextBoxColumn.HeaderText = "DNI_Prof";
			this.dNIProfDataGridViewTextBoxColumn.Name = "dNIProfDataGridViewTextBoxColumn";
			// 
			// asignaturaBindingSource
			// 
			this.asignaturaBindingSource.DataMember = "Asignatura";
			this.asignaturaBindingSource.DataSource = this.escuelaDataSet;
			// 
			// profesoresTableAdapter
			// 
			this.profesoresTableAdapter.ClearBeforeFill = true;
			// 
			// asignaturaTableAdapter
			// 
			this.asignaturaTableAdapter.ClearBeforeFill = true;
			// 
			// btnAceptarProfesor
			// 
			this.btnAceptarProfesor.Location = new System.Drawing.Point(225, 247);
			this.btnAceptarProfesor.Name = "btnAceptarProfesor";
			this.btnAceptarProfesor.Size = new System.Drawing.Size(75, 23);
			this.btnAceptarProfesor.TabIndex = 1;
			this.btnAceptarProfesor.Text = "Aceptar";
			this.btnAceptarProfesor.UseVisualStyleBackColor = true;
			this.btnAceptarProfesor.Click += new System.EventHandler(this.btnAceptarProfesor_Click);
			// 
			// btnAceptarAlumno
			// 
			this.btnAceptarAlumno.Location = new System.Drawing.Point(231, 252);
			this.btnAceptarAlumno.Name = "btnAceptarAlumno";
			this.btnAceptarAlumno.Size = new System.Drawing.Size(75, 23);
			this.btnAceptarAlumno.TabIndex = 1;
			this.btnAceptarAlumno.Text = "Aceptar";
			this.btnAceptarAlumno.UseVisualStyleBackColor = true;
			this.btnAceptarAlumno.Click += new System.EventHandler(this.btnAceptarAlumno_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(229, 259);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Aceptar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 319);
			this.Controls.Add(this.btnAceptarAsignatura);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Escuela";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.escuelaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.btnAceptarAsignatura.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private EscuelaDataSet escuelaDataSet;
		private System.Windows.Forms.BindingSource alumnosBindingSource;
		private EscuelaDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fNacimientoDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabControl btnAceptarAsignatura;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.BindingSource profesoresBindingSource;
		private EscuelaDataSetTableAdapters.ProfesoresTableAdapter profesoresTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.BindingSource asignaturaBindingSource;
		private EscuelaDataSetTableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAsignaturaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dNIProfDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnAceptarProfesor;
		private System.Windows.Forms.Button btnAceptarAlumno;
		private System.Windows.Forms.Button button3;
	}
}

