/*
 * Creado por SharpDevelop.
 * Quispe Alejandra 
 * Fecha: 9/21/2016
 * Hora: 11:34 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;

namespace HolaMundo
{
	internal sealed class Program
	{
		
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
