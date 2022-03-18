using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcultorConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b, menu;

			Console.Title = "APLIKASI CALCULATOR";
			Console.WriteLine("\t\tCALCULATOR APPLICATION");
			Console.WriteLine();
			Console.WriteLine("1. Penambahan");
			Console.WriteLine("2. Pengurangan");
			Console.WriteLine("3. Perkalian");
			Console.WriteLine("4. Pembagian");
			Console.WriteLine("5. Sisa bagi");
			Console.WriteLine();
			Console.Write("Masukkan menu yang anda inginkan : ");
			menu = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			switch (menu)
			{
				case 1:
					Console.WriteLine("perhatihan nilai input a dan b (contoh a + b)!");
					Console.Write("Inputkan nilai a : ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Inputkan nilai b : ");
					b = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();
					Console.WriteLine("Hasil penambahan dari {0} + {1} = {2}", a, b, penambahan(a, b));
					break;
				case 2:
					Console.WriteLine("perhatihan nilai input a dan b (contoh a - b)!");
					Console.Write("Inputkan nilai a : ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Inputkan nilai b : ");
					b = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();
					Console.WriteLine("Hasil pengurangan dari {0} - {1} = {2}", a, b, pengurangan(a, b));
					break;
				case 3:
					Console.WriteLine("perhatihan nilai input a dan b (contoh a x b)!");
					Console.Write("Inputkan nilai a : ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Inputkan nilai b : ");
					b = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();
					Console.WriteLine("Hasil perkalian dari {0} x {1} = {2}", a, b, perkalian(a, b));
					break;
				case 4:
					Console.WriteLine("perhatihan nilai input a dan b (contoh a : b)!");
					Console.Write("Inputkan nilai a : ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Inputkan nilai b : ");
					b = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();
					Console.WriteLine("Hasil pembagian dari {0} : {1} = {2}", a, b, pembagian(a, b));
					break;
				case 5:
					Console.WriteLine("perhatihan nilai input a dan b (contoh a % b)!");
					Console.Write("Inputkan nilai a : ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Inputkan nilai b : ");
					b = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();
					Console.WriteLine("Hasil sisa bagi dari {0} % {1} = {2}", a, b, sisabagi(a, b));
					break;
				default:
					Console.WriteLine("Menu tidak tersedia, mohon masukkan sesuai menu yang ada dan coba lagi");
					break;

			}
		}
		static int penambahan(int a, int b)
		{
			return a + b;
		}
		static int pengurangan(int a, int b)
		{
			return a - b;
		}
		static int perkalian(int a, int b)
		{
			return a * b;
		}
		static int pembagian(int a, int b)
		{
			return a / b;
		}
		static int sisabagi(int a, int b)
		{
			return a % b;
		}
	}
}	