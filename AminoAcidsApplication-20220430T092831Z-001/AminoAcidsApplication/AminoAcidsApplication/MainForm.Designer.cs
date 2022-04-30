/*
 * Created by SharpDevelop.
 * User: student
 * Date: 21-Oct-20
 * Time: 21:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AminoAcidsApplication
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonStartcodon;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonTAG;
		private System.Windows.Forms.Button buttonTGA;
		private System.Windows.Forms.Button buttonTAA;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxOpenedfile;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button buttonStartRNA;
		private System.Windows.Forms.Button buttonUAG;
		private System.Windows.Forms.Button buttonUGA;
		private System.Windows.Forms.Button buttonUAA;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonStartRNA = new System.Windows.Forms.Button();
			this.buttonStartcodon = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonUAG = new System.Windows.Forms.Button();
			this.buttonUGA = new System.Windows.Forms.Button();
			this.buttonUAA = new System.Windows.Forms.Button();
			this.buttonTAG = new System.Windows.Forms.Button();
			this.buttonTGA = new System.Windows.Forms.Button();
			this.buttonTAA = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxFileName = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBoxOpenedfile = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(272, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(410, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "Show polypeptid chain";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(272, 52);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(410, 85);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1KeyDown);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(272, 328);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(410, 146);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(272, 219);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox3.Size = new System.Drawing.Size(410, 72);
			this.textBox3.TabIndex = 3;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonStartRNA);
			this.groupBox1.Controls.Add(this.buttonStartcodon);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(51, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 159);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Insert start codon";
			// 
			// buttonStartRNA
			// 
			this.buttonStartRNA.Enabled = false;
			this.buttonStartRNA.Location = new System.Drawing.Point(7, 91);
			this.buttonStartRNA.Name = "buttonStartRNA";
			this.buttonStartRNA.Size = new System.Drawing.Size(164, 48);
			this.buttonStartRNA.TabIndex = 1;
			this.buttonStartRNA.Text = "AUG";
			this.buttonStartRNA.UseVisualStyleBackColor = true;
			this.buttonStartRNA.Click += new System.EventHandler(this.ButtonStartRNAClick);
			// 
			// buttonStartcodon
			// 
			this.buttonStartcodon.Location = new System.Drawing.Point(7, 33);
			this.buttonStartcodon.Name = "buttonStartcodon";
			this.buttonStartcodon.Size = new System.Drawing.Size(164, 48);
			this.buttonStartcodon.TabIndex = 0;
			this.buttonStartcodon.Text = "ATG";
			this.buttonStartcodon.UseVisualStyleBackColor = true;
			this.buttonStartcodon.Click += new System.EventHandler(this.ButtonStartcodonClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonUAG);
			this.groupBox2.Controls.Add(this.buttonUGA);
			this.groupBox2.Controls.Add(this.buttonUAA);
			this.groupBox2.Controls.Add(this.buttonTAG);
			this.groupBox2.Controls.Add(this.buttonTGA);
			this.groupBox2.Controls.Add(this.buttonTAA);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(720, 52);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(334, 196);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Insert stop codon";
			// 
			// buttonUAG
			// 
			this.buttonUAG.Enabled = false;
			this.buttonUAG.Location = new System.Drawing.Point(168, 141);
			this.buttonUAG.Name = "buttonUAG";
			this.buttonUAG.Size = new System.Drawing.Size(155, 48);
			this.buttonUAG.TabIndex = 5;
			this.buttonUAG.Text = "UAG";
			this.buttonUAG.UseVisualStyleBackColor = true;
			this.buttonUAG.Click += new System.EventHandler(this.ButtonUAGClick);
			// 
			// buttonUGA
			// 
			this.buttonUGA.Enabled = false;
			this.buttonUGA.Location = new System.Drawing.Point(168, 87);
			this.buttonUGA.Name = "buttonUGA";
			this.buttonUGA.Size = new System.Drawing.Size(155, 48);
			this.buttonUGA.TabIndex = 4;
			this.buttonUGA.Text = "UGA";
			this.buttonUGA.UseVisualStyleBackColor = true;
			this.buttonUGA.Click += new System.EventHandler(this.ButtonUGAClick);
			// 
			// buttonUAA
			// 
			this.buttonUAA.Enabled = false;
			this.buttonUAA.Location = new System.Drawing.Point(168, 33);
			this.buttonUAA.Name = "buttonUAA";
			this.buttonUAA.Size = new System.Drawing.Size(155, 48);
			this.buttonUAA.TabIndex = 3;
			this.buttonUAA.Text = "UAA";
			this.buttonUAA.UseVisualStyleBackColor = true;
			this.buttonUAA.Click += new System.EventHandler(this.ButtonUAAClick);
			// 
			// buttonTAG
			// 
			this.buttonTAG.Enabled = false;
			this.buttonTAG.Location = new System.Drawing.Point(7, 141);
			this.buttonTAG.Name = "buttonTAG";
			this.buttonTAG.Size = new System.Drawing.Size(155, 48);
			this.buttonTAG.TabIndex = 2;
			this.buttonTAG.Text = "TAG";
			this.buttonTAG.UseVisualStyleBackColor = true;
			this.buttonTAG.Click += new System.EventHandler(this.ButtonATCClick);
			// 
			// buttonTGA
			// 
			this.buttonTGA.Enabled = false;
			this.buttonTGA.Location = new System.Drawing.Point(7, 87);
			this.buttonTGA.Name = "buttonTGA";
			this.buttonTGA.Size = new System.Drawing.Size(155, 48);
			this.buttonTGA.TabIndex = 1;
			this.buttonTGA.Text = "TGA";
			this.buttonTGA.UseVisualStyleBackColor = true;
			this.buttonTGA.Click += new System.EventHandler(this.ButtonACTClick);
			// 
			// buttonTAA
			// 
			this.buttonTAA.Enabled = false;
			this.buttonTAA.Location = new System.Drawing.Point(7, 33);
			this.buttonTAA.Name = "buttonTAA";
			this.buttonTAA.Size = new System.Drawing.Size(155, 48);
			this.buttonTAA.TabIndex = 0;
			this.buttonTAA.Text = "TAA";
			this.buttonTAA.UseVisualStyleBackColor = true;
			this.buttonTAA.Click += new System.EventHandler(this.ButtonATTClick);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClear.Location = new System.Drawing.Point(917, 283);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(165, 64);
			this.buttonClear.TabIndex = 6;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.buttonSave);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.textBoxFileName);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.Location = new System.Drawing.Point(727, 267);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 162);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Save sequences in a file";
			// 
			// buttonSave
			// 
			this.buttonSave.Enabled = false;
			this.buttonSave.Location = new System.Drawing.Point(6, 100);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(158, 46);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(7, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Enter a file name:";
			// 
			// textBoxFileName
			// 
			this.textBoxFileName.Location = new System.Drawing.Point(6, 63);
			this.textBoxFileName.Name = "textBoxFileName";
			this.textBoxFileName.Size = new System.Drawing.Size(158, 23);
			this.textBoxFileName.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBoxOpenedfile);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.buttonBrowse);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox4.Location = new System.Drawing.Point(46, 231);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(189, 249);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Insert DNA sequence from a file";
			// 
			// textBoxOpenedfile
			// 
			this.textBoxOpenedfile.Location = new System.Drawing.Point(12, 137);
			this.textBoxOpenedfile.Multiline = true;
			this.textBoxOpenedfile.Name = "textBoxOpenedfile";
			this.textBoxOpenedfile.ReadOnly = true;
			this.textBoxOpenedfile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxOpenedfile.Size = new System.Drawing.Size(164, 106);
			this.textBoxOpenedfile.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(36, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 24);
			this.label5.TabIndex = 2;
			this.label5.Text = "File name:";
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(12, 52);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(164, 48);
			this.buttonBrowse.TabIndex = 1;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowseClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(338, 302);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(297, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Amio acid sequence in the polypeptid chain:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton1.Location = new System.Drawing.Point(351, 17);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(229, 24);
			this.radioButton1.TabIndex = 11;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Enter a coding DNA sequence:";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton2.Location = new System.Drawing.Point(351, 187);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(249, 24);
			this.radioButton2.TabIndex = 12;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Enter a Messeger RNA sequence:";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1087, 484);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "AminoAcidsApplication";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
