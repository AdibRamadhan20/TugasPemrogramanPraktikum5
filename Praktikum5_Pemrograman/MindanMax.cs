using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum5_Pemrograman
{
	internal class MindanMax
	{
		public int MencariNilaiMin(int a, int b)
		{
			return a < b ? a : b;
		}
		
		public double MencariNilaiMin(double a, double b)
		{
			return a < b ? a : b;
		}
		public int MencariNilaiMax(int a, int b)
		{
			return a > b ? a : b;
		}

		public double MencariNilaiMax(double a, double b)
		{
			return a > b ? a : b;
		}

	}
}
