using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LeapYear
    {
        public static void ReadInput()
	{
		Console.WriteLine("Enter Year : "); 
	    int year = Convert.ToInt32(Console.ReadLine());
		CheckYear(year);
	}
	
	    public static void CheckYear(int year)
		{
		
		if(year%400==0)
		{
			Console.WriteLine(year+" "+"is a leap year");
		}
		else if( year% 100 !=0 && year% 4 ==0)
		{
			Console.WriteLine(year+" "+"is a leap year");
		}
	    else
		{
			Console.WriteLine(year+" "+"is not a leap year");
		}
			//Console.Read();
	   }
    }
}
