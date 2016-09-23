/*
 * Creado por SharpDevelop.
 * Quispe Alejandra 
 * Fecha: 9/21/2016
 * Hora: 11:34 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace HolaMundo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio_mInimo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Maximo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio_mInimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio_Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(237, 255);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Cargar Datos";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Cod,
			this.Nombre,
			this.Marca,
			this.Nombre_Proveedor,
			this.Precio_mInimo,
			this.Precio_Maximo,
			this.Stock});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.Location = new System.Drawing.Point(12, 45);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(670, 161);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// Cod
			// 
			this.Cod.HeaderText = "Codigo";
			this.Cod.Name = "Cod";
			this.Cod.ReadOnly = true;
			this.Cod.Width = 80;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Marca
			// 
			this.Marca.HeaderText = "Marca";
			this.Marca.Name = "Marca";
			this.Marca.ReadOnly = true;
			// 
			// Nombre_Proveedor
			// 
			this.Nombre_Proveedor.HeaderText = "Nombre_Proveedor";
			this.Nombre_Proveedor.Name = "Nombre_Proveedor";
			this.Nombre_Proveedor.ReadOnly = true;
			// 
			// Precio_mInimo
			// 
			this.Precio_mInimo.HeaderText = "Precio_mInimo";
			this.Precio_mInimo.Name = "Precio_mInimo";
			this.Precio_mInimo.ReadOnly = true;
			this.Precio_mInimo.Width = 80;
			// 
			// Precio_Maximo
			// 
			this.Precio_Maximo.HeaderText = "Precio_Maximo";
			this.Precio_Maximo.Name = "Precio_Maximo";
			this.Precio_Maximo.ReadOnly = true;
			this.Precio_Maximo.Width = 80;
			// 
			// Stock
			// 
			this.Stock.HeaderText = "Stock";
			this.Stock.Name = "Stock";
			this.Stock.ReadOnly = true;
			this.Stock.Width = 80;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 357);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "ABMArticulos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
