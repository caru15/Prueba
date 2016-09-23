/*
 * Creado por SharpDevelop.
 * Quispe Alejandra 
 * Fecha: 9/21/2016
 * Hora: 11:34 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace HolaMundo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			StreamReader objReader;
			objReader = File.OpenText(@"C:\Users\casa\Documents\SharpDevelop Projects\HolaMundo\HolaMundo\bin\Debug\articulos.txt");
			string sline="";
		
			
			//dataGridView1.AllowUserToAddRows = false;
			do{
				sline=objReader.ReadLine();
				if((sline != null)){
					string[] arreglo=sline.Split('-');
					
					dataGridView1.Rows.Add(arreglo);
				}
			}while (!(sline == null));
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
	
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
