/*
 * Created by SharpDevelop.
 * User: student
 * Date: 21-Oct-20
 * Time: 21:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AminoAcidsApplication
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string dnaSequence, rna, aminoacids;
		string DNA()
		{
			for (int i = 0; i < rna.Length; i++)
			{
				switch (rna.Substring(i,1))
				   {
				        case "U":dnaSequence +="T";
				        	break;
				        case "A": dnaSequence+="A";
				        	break;
				        case "G": dnaSequence+="G";
				        	break;
				        case "C": dnaSequence+="C";
				        	break;
				    }
			}
			return dnaSequence;
		}
		string RNA()
		{
			for (int i = 0; i < dnaSequence.Length; i++)
			{
				switch (dnaSequence.Substring(i,1))
				   {
				        case "A": rna+="A";
				        	break;
				        case "T": rna+="U";
				        	break;
				        case "G": rna+="G";
				        	break;
				        case "C": rna+="C";
				        	break;
				    }
			}
			return rna;
		}
		string AminoAcidsSequence()
		{
			for (int i = 0; i <=(rna.Length)-3; i+=3)
			{
				switch (rna.Substring(i,3).ToUpper())
				{
					case "UAA": case "UAG": case "UGA":
						aminoacids+=string.Format("{0}","Stop codon"+Environment.NewLine);
						break;
					case "AUG":
						if (i==0)
						{
							aminoacids+=string.Format("{0}","Start codon"+Environment.NewLine);
							break;
						}
						else
						{
							aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Met) Methionine"+Environment.NewLine);
							break;
						}
					case "UUU": case "UUC":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Phe) Phenylalanine"+Environment.NewLine);
						break;
					case "UUA": case "UUG": case "CUU": case "CUC": case "CUA": case "CUG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Leu) Leucine"+Environment.NewLine);
						break;
					case "AUU": case "AUC": case "AUA":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Ile) Isoleucine"+Environment.NewLine);
						break;
					case "GUU": case "GUC": case "GUA": case "GUG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Val) Valine"+Environment.NewLine);
						break;
					case "UCU": case "UCC": case "UCA": case "UCG": case "AGU": case "AGC":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Ser) Serine"+Environment.NewLine);
						break;
					case "CCU": case "CCC": case "CCA": case "CCG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Pro) Proline"+Environment.NewLine);
						break;
					case "ACU": case "ACC": case "ACA": case "ACG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Thr) Threonin"+Environment.NewLine);
						break;
					case "GCU": case "GCC": case "GCA": case "GCG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Ala) Alanine"+Environment.NewLine);
						break;
					case "UAU": case "UAC":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Tyr) Tyrosine"+Environment.NewLine);
						break;
					case "CAU": case "CAC":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(His) Histidine"+Environment.NewLine);
						break;
					case "CAA": case "CAG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Gln) Glutamine"+Environment.NewLine);
						break;
					case "AAU": case "AAC":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Asn) Asparagine"+Environment.NewLine);
						break;
					case "AAA": case "AAG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Lys) Lysine"+Environment.NewLine);
						break;
					case "GAU": case "GAC":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Asp) Aspartic acid"+Environment.NewLine);
						break;
					case "GAA": case "GAG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Glu) Glutamic acid"+Environment.NewLine);
						break;
					case "UGU": case "UGC":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Cys) Cysteine"+Environment.NewLine);
						break;
					case "UGG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Trp) Tryptophan"+Environment.NewLine);
						break;
					case "CGU": case "CGC": case "CGA": case "CGG": case "AGA": case "AGG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Arg) Arginine"+Environment.NewLine);
						break;
					case "GGU": case "GGC": case "GGA": case "GGG":
						aminoacids+=string.Format("{0,-10}{1}",(i/3)+1,"(Gly) Glycine"+Environment.NewLine);
						break;
				}
			}
			return aminoacids;
		}
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
		void Button1Click(object sender, EventArgs e)
		{
			dnaSequence="";
			rna="";
			aminoacids="";
			if (radioButton1.Checked==true)
			{
				buttonStartcodon.Enabled=true;
				buttonStartRNA.Enabled=false;
				dnaSequence=textBox1.Text;
				textBox3.Text=RNA();
			}
			else if (radioButton2.Checked==true)
			{
				buttonStartcodon.Enabled=false;
				buttonStartRNA.Enabled=true;
				rna=textBox3.Text;
				textBox1.Text=DNA();
			}
			textBox2.Text=AminoAcidsSequence();
			buttonSave.Enabled=true;
		}
		void ButtonClearClick(object sender, EventArgs e)
		{
			textBoxOpenedfile.Clear();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBoxFileName.Clear();
			if (radioButton1.Checked==true)
			{
				buttonStartcodon.Enabled=true;
			}
			else
			{
				buttonStartRNA.Enabled=true;
			}
			buttonTGA.Enabled=false;
			buttonTAG.Enabled=false;
			buttonTAA.Enabled=false;
			dnaSequence="";
			rna="";
			aminoacids="";
			buttonSave.Enabled=false;
			buttonUAA.Enabled=false;
			buttonUGA.Enabled=false;
			buttonUAG.Enabled=false;
		}
		void ButtonSaveClick(object sender, EventArgs e)
		{
			try{
			string info="   Coding DNA sequence: " +dnaSequence+Environment.NewLine+"Messenger RNA sequence: "+rna+Environment.NewLine+aminoacids;
			string filename=textBoxFileName.Text;
			File.WriteAllText("D:\\"+filename+".txt",info);			
			MessageBox.Show("Protein sequence succesfully saved!");
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			buttonStartcodon.Enabled=true;
			buttonTGA.Enabled=false;
			buttonTAG.Enabled=false;
			buttonTAA.Enabled=false;
			dnaSequence="";
			rna="";
			aminoacids="";
			buttonSave.Enabled=false;
			textBoxFileName.Clear();
			}
			catch {
				MessageBox.Show("Could not save the file, D:// required");
			}
		}
		void ButtonBrowseClick(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog1.ShowDialog();
			if(result == DialogResult.OK)
			{
				textBoxOpenedfile.Text = openFileDialog1.FileName;
				if (radioButton1.Checked==true)
				{
					textBox1.Text=File.ReadAllText(textBoxOpenedfile.Text);
					buttonTGA.Enabled=true;
					buttonTAA.Enabled=true;
					buttonTAG.Enabled=true;
				}
				else
				{
					textBox3.Text=File.ReadAllText(textBoxOpenedfile.Text);
					buttonUAA.Enabled=true;
					buttonUGA.Enabled=true;
					buttonUAG.Enabled=true;
				}
			}
		}
		void TextBox1KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
			string validChars = " GTAC";
			char backspace='\b';
			validChars+=backspace;
            if(validChars.IndexOf(e.KeyChar)<0)
            {
                e.Handled = true;
                return;
            }
            textBox1.Text+="";
            buttonTGA.Enabled=true;
			buttonTAA.Enabled=true;
			buttonTAG.Enabled=true;
		}
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
			string validChars = " GUAC";
			char backspace='\b';
			validChars+=backspace;
            if(validChars.IndexOf(e.KeyChar)<0)
            {
                e.Handled = true;
                return;
            }
            textBox3.Text+="";
            buttonUAA.Enabled=true;
			buttonUGA.Enabled=true;
			buttonUAG.Enabled=true;
		}
		void TextBox1KeyDown(object sender, KeyEventArgs e)
		{
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			textBox3.ReadOnly=true;
			textBox1.ReadOnly=false;
			buttonStartcodon.Enabled=true;
			buttonStartRNA.Enabled=false;
			buttonUGA.Enabled=false;
			buttonUAG.Enabled=false;
			buttonUAA.Enabled=false;
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			textBox3.ReadOnly=false;
			textBox1.ReadOnly=true;
			buttonStartcodon.Enabled=false;
			buttonStartRNA.Enabled=true;
			buttonTGA.Enabled=false;
			buttonTAG.Enabled=false;
			buttonTAA.Enabled=false;
		}
		void ButtonStartRNAClick(object sender, EventArgs e)
		{
			textBox3.Text+="AUG";
			buttonStartRNA.Enabled=false;
			buttonUGA.Enabled=true;
			buttonUAG.Enabled=true;
			buttonUAA.Enabled=true;
			buttonSave.Enabled=true;
		}
		void ButtonUAAClick(object sender, EventArgs e)
		{
			textBox3.Text+="UAA";
			buttonStartRNA.Enabled=true;
			buttonUGA.Enabled=false;
			buttonUAG.Enabled=false;
			buttonUAA.Enabled=false;
			buttonSave.Enabled=true;
		}
		void ButtonUGAClick(object sender, EventArgs e)
		{
			textBox3.Text+="UGA";
			buttonStartRNA.Enabled=true;
			buttonUGA.Enabled=false;
			buttonUAG.Enabled=false;
			buttonUAA.Enabled=false;
			buttonSave.Enabled=true;
		}
		void ButtonUAGClick(object sender, EventArgs e)
		{
			textBox3.Text+="UAG";
			buttonStartRNA.Enabled=true;
			buttonUGA.Enabled=false;
			buttonUAG.Enabled=false;
			buttonUAA.Enabled=false;
			buttonSave.Enabled=true;
		}
		void ButtonStartcodonClick(object sender, EventArgs e)
		{
			textBox1.Text+="ATG";
			buttonStartcodon.Enabled=false;
			buttonTGA.Enabled=true;
			buttonTAG.Enabled=true;
			buttonTAA.Enabled=true;
			buttonSave.Enabled=true;
		}
		void ButtonATTClick(object sender, EventArgs e)
		{
			textBox1.Text+="TAA";
			buttonStartcodon.Enabled=true;
			buttonTGA.Enabled=false;
			buttonTAG.Enabled=false;
			buttonTAA.Enabled=false;
			buttonSave.Enabled=true;
		}
		void ButtonACTClick(object sender, EventArgs e)
		{
			textBox1.Text+="TGA";
			buttonStartcodon.Enabled=true;
			buttonTGA.Enabled=false;
			buttonTAG.Enabled=false;
			buttonTAA.Enabled=false;
			buttonSave.Enabled=true;
		}
		void ButtonATCClick(object sender, EventArgs e)
		{
			textBox1.Text+="TAG";
			buttonStartcodon.Enabled=true;
			buttonTGA.Enabled=false;
			buttonTAG.Enabled=false;
			buttonTAA.Enabled=false;
			buttonSave.Enabled=true;
		}
	}
}