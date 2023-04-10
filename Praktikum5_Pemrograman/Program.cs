using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum5_Pemrograman
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MindanMax mindanmax1 = new MindanMax();
			Console.WriteLine("=========================\nMencari Nilai Min dan Max\n=========================");
			Console.WriteLine("Nilai a : 4.092\nNilai b : 8.33\n===================================================");
			Console.WriteLine("Nilai min dari kedua nilai tersebut adalah : {0}", mindanmax1.MencariNilaiMin(4.092, 8.33));
			Console.WriteLine("Nilai max dari kedua nilai tersebut adalah : {0}", mindanmax1.MencariNilaiMax(4.092, 8.33));
			Console.ReadLine();
		}
	}
}
