/*
 * Creado por SharpDevelop.
 * Quispe Alejandra 
 * Fecha: 9/26/2016
 * Hora: 8:04 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HolaMundo
{
	/// <summary>
	/// Description of FormModificar.
	/// </summary>
	public partial class FormModificar : Form
	{
		public FormModificar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
