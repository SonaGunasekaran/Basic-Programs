using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LargestOfThree
    {
        public static void ReadInput()
        {
            //Get the input from user
            Console.WriteLine("Enter the number one value : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number Two value : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number Three value : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            LargestNumber(num1,num2,num3);
          }


            public static void LargestNumber(int num1 ,int num2,int num3)
            { 
                 //check the Largest among three numbers
                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine(num1 + " is a Largest among Three");
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine(num2 + " is a Largest among Three");
                }
                else
                {
                    Console.WriteLine(num3 + " is a Largest among Three");
                }
            }
        }
	}

