/*
 * Created by SharpDevelop.
 * User: student
 * Date: 21-Oct-20
 * Time: 15:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AminoAcids
{
	class Genes
	{
		private string dnaSequence, rna, aminoacids;
		public Genes(string dna)
		{
			dnaSequence=dna;
			rna="";
			aminoacids="";
		}
		public string RNA()
		{
			for (int i = 0; i < dnaSequence.Length; i++)
			{
				switch (dnaSequence.Substring(i,1))
				   {
				        case "A": rna+="U";
				        	break;
				        case "T": rna+="A";
				        	break;
				        case "G": rna+="C";
				        	break;
				        case "C": rna+="G";
				        	break;
				        default: Console.WriteLine("Invalid nucleotides!!!");
				        	return "";
				    }
			}
			Console.Write("{0}","Messenger RNA sequence: ");
			Console.WriteLine(rna);
			Console.WriteLine("This DNA sequence contains information for the synthesis of the following polypeptide:");
			Console.WriteLine("");
			return rna;
		}
		public string AminoAcidsSequence()
		{
			for (int i = 0; i < (rna.Length)-2; i+=3)
			{
				switch (rna.Substring(i,3).ToUpper())
				{
					case "UAA": case "UAG": case "UGA":
						aminoacids+=string.Format("{0}","Stop codone"+Environment.NewLine);
						break;
					case "AUG":
						if (i==0)
						{
							aminoacids+=string.Format("{0}","Start codone"+Environment.NewLine);
							break;
						}
						else
						{
							aminoacids+=string.Format("{0}","(Met) Methionine"+Environment.NewLine);
							break;
						}
					case "UUU": case "UUC":
						aminoacids+=string.Format("{0}","(Phe) Phenylalanine"+Environment.NewLine);
						break;
					case "UUA": case "UUG": case "CUU": case "CUC": case "CUA": case "CUG":
						aminoacids+=string.Format("{0}", "(Leu) Leucine"+Environment.NewLine);
						break;
					case "AUU": case "AUC": case "AUA":
						aminoacids+=string.Format("{0}","(Ile) Isoleucine"+Environment.NewLine);
						break;
					case "GUU": case "GUC": case "GUA": case "GUG":
						aminoacids+=string.Format("{0}","(Val) Valine"+Environment.NewLine);
						break;
					case "UCU": case "UCC": case "UCA": case "UCG": case "AGU": case "AGC":
						aminoacids+=string.Format("{0}","(Ser) Serine"+Environment.NewLine);
						break;
					case "CCU": case "CCC": case "CCA": case "CCG":
						aminoacids+=string.Format("{0}","(Pro) Proline"+Environment.NewLine);
						break;
					case "ACU": case "ACC": case "ACA": case "ACG":
						aminoacids+=string.Format("{0}","(Thr) Threonin"+Environment.NewLine);
						break;
					case "GCU": case "GCC": case "GCA": case "GCG":
						aminoacids+=string.Format("{0}","(Ala) Alanine"+Environment.NewLine);
						break;
					case "UAU": case "UAC":
						aminoacids+=string.Format("{0}","(Tyr) Tyrosine"+Environment.NewLine);
						break;
					
					case "CAU": case "CAC":
						aminoacids+=string.Format("{0}","(His) Histidine"+Environment.NewLine);
						break;
					case "CAA": case "CAG":
						aminoacids+=string.Format("{0}","(Gln) Glutamine"+Environment.NewLine);
						break;
					case "AAU": case "AAC":
						aminoacids+=string.Format("{0}","(Asn) Asparagine"+Environment.NewLine);
						break;
					case "AAA": case "AAG":
						aminoacids+=string.Format("{0}","(Lys) Lysine"+Environment.NewLine);
						break;
					case "GAU": case "GAC":
						aminoacids+=string.Format("{0}","(Asp) Aspartic acid"+Environment.NewLine);
						break;
					case "GAA": case "GAG":
						aminoacids+=string.Format("{0}","(Glu) Glutamic acid"+Environment.NewLine);
						break;
					case "UGU": case "UGC":
						aminoacids+=string.Format("{0}","(Cys) Cysteine"+Environment.NewLine);
						break;
					case "UGG":
						aminoacids+=string.Format("{0}","(Trp) Tryptophan"+Environment.NewLine);
						break;
					case "CGU": case "CGC": case "CGA": case "CGG": case "AGA": case "AGG":
						aminoacids+=string.Format("{0}","(Arg) Arginine"+Environment.NewLine);
						break;
					case "GGU": case "GGC": case "GGA": case "GGG":
						aminoacids+=string.Format("{0}","(Tyr) Tyrosine"+Environment.NewLine);
						break;
				}
			}
			Console.Write(aminoacids);
			return aminoacids;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter a DNA sequence: ");
			string dna="";
			char c =char.ToUpper(Console.ReadKey(true).KeyChar);
			while (c != '\r') {
				if(c=='A' || c=='G' || c=='C' || c=='T') 
				{
					Console.Write(c);
					dna += c;
				}
				c =char.ToUpper(Console.ReadKey(true).KeyChar);
			}
			Console.WriteLine();
			Genes g=new Genes(dna);
			g.RNA();
			g.AminoAcidsSequence();
						
			Console.ReadKey(true);
		}
	}
}