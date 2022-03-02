/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 02/03/2022
 * Time: 15:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas_pt4_2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Nama : " + this.tBNama.Text  + " NIM : " + this.tBNIM.Text  + " Kelas : " + this.tBKelas.Text  + " Mata Kuliah : " + this.tBMatkul.Text);			
		}
	}
}
