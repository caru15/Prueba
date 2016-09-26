/*
 * Creado por SharpDevelop.
 * Quispe Alejandra 
 * Fecha: 9/26/2016
 * Hora: 8:04 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace HolaMundo
{
	partial class FormModificar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label NroPrestamo;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.TextBox txtPrestamo;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label dni;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label apellido;
		private System.Windows.Forms.Label nombre;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.NroPrestamo = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.txtPrestamo = new System.Windows.Forms.TextBox();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dni = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.apellido = new System.Windows.Forms.Label();
			this.nombre = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(127, 171);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(119, 20);
			this.textBox2.TabIndex = 29;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(35, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 28;
			this.label3.Text = "Telefono Movil:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(127, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 20);
			this.textBox1.TabIndex = 27;
			// 
			// NroPrestamo
			// 
			this.NroPrestamo.Location = new System.Drawing.Point(34, 23);
			this.NroPrestamo.Name = "NroPrestamo";
			this.NroPrestamo.Size = new System.Drawing.Size(101, 25);
			this.NroPrestamo.TabIndex = 26;
			this.NroPrestamo.Text = "Nro de Prestamo:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(127, 49);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(119, 20);
			this.txtNombre.TabIndex = 17;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(231, 275);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 40);
			this.btnSalir.TabIndex = 25;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(127, 275);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(78, 40);
			this.btnLimpiar.TabIndex = 24;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(34, 275);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(80, 40);
			this.btnGuardar.TabIndex = 23;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(127, 78);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(119, 20);
			this.txtDni.TabIndex = 21;
			// 
			// txtPrestamo
			// 
			this.txtPrestamo.Location = new System.Drawing.Point(127, 206);
			this.txtPrestamo.Name = "txtPrestamo";
			this.txtPrestamo.Size = new System.Drawing.Size(119, 20);
			this.txtPrestamo.TabIndex = 22;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(127, 144);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(119, 20);
			this.txtDomicilio.TabIndex = 20;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(127, 104);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(119, 20);
			this.txtApellido.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(34, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "Préstamo: ";
			// 
			// dni
			// 
			this.dni.Location = new System.Drawing.Point(34, 52);
			this.dni.Name = "dni";
			this.dni.Size = new System.Drawing.Size(100, 23);
			this.dni.TabIndex = 15;
			this.dni.Text = "DNI: ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(34, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Telefono Fijo:";
			// 
			// apellido
			// 
			this.apellido.Location = new System.Drawing.Point(34, 107);
			this.apellido.Name = "apellido";
			this.apellido.Size = new System.Drawing.Size(100, 23);
			this.apellido.TabIndex = 18;
			this.apellido.Text = "Apellido: ";
			// 
			// nombre
			// 
			this.nombre.Location = new System.Drawing.Point(34, 75);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(100, 23);
			this.nombre.TabIndex = 13;
			this.nombre.Text = "Nombre: ";
			// 
			// FormModificar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 334);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.NroPrestamo);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.txtPrestamo);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dni);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.apellido);
			this.Controls.Add(this.nombre);
			this.Name = "FormModificar";
			this.Text = "FormModificar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
