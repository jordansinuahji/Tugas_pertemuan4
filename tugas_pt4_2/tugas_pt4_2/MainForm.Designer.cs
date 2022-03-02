/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 02/03/2022
 * Time: 15:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas_pt4_2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tBNama = new System.Windows.Forms.TextBox();
			this.tBNIM = new System.Windows.Forms.TextBox();
			this.tBKelas = new System.Windows.Forms.TextBox();
			this.tBMatkul = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NIM";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kelas";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(25, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Matkul";
			// 
			// tBNama
			// 
			this.tBNama.Location = new System.Drawing.Point(194, 32);
			this.tBNama.Name = "tBNama";
			this.tBNama.Size = new System.Drawing.Size(179, 20);
			this.tBNama.TabIndex = 4;
			// 
			// tBNIM
			// 
			this.tBNIM.Location = new System.Drawing.Point(194, 70);
			this.tBNIM.Name = "tBNIM";
			this.tBNIM.Size = new System.Drawing.Size(179, 20);
			this.tBNIM.TabIndex = 5;
			// 
			// tBKelas
			// 
			this.tBKelas.Location = new System.Drawing.Point(194, 115);
			this.tBKelas.Name = "tBKelas";
			this.tBKelas.Size = new System.Drawing.Size(179, 20);
			this.tBKelas.TabIndex = 6;
			// 
			// tBMatkul
			// 
			this.tBMatkul.Location = new System.Drawing.Point(194, 158);
			this.tBMatkul.Name = "tBMatkul";
			this.tBMatkul.Size = new System.Drawing.Size(179, 20);
			this.tBMatkul.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(194, 215);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Klik Saya";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tBMatkul);
			this.Controls.Add(this.tBKelas);
			this.Controls.Add(this.tBNIM);
			this.Controls.Add(this.tBNama);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "tugas_pt4_2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tBMatkul;
		private System.Windows.Forms.TextBox tBKelas;
		private System.Windows.Forms.TextBox tBNIM;
		private System.Windows.Forms.TextBox tBNama;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
