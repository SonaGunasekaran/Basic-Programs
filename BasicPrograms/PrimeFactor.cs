using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PrimeFactor
    {
		public static void ReadInput()
		{
			Console.WriteLine("Enter the number : ");
			int num = Convert.ToInt32(Console.ReadLine());
			FindFactors(num);
		}

		public static void FindFactors(int num)
		{
			while (num % 2 == 0)
			{
				Console.WriteLine(2 + " ");
				num /= 2;
			}
			for (int i = 3; i <= num; i += 2)
			{
				if (num % i == 0)
				{
					Console.WriteLine(i + " ");
					num /= i;
				}
			}
			if (num > 2)
				Console.Write(num);

		}

	}
}
