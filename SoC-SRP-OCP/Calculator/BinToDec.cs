using System;
using System.Security.Policy;

namespace CalculatorSystem
{
	public class BinToDec : Calculate
	{
		public int[] EnterValues() { 
			Console.WriteLine("Enter the first value: ");
			int valueOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the second value: ");
            int valueTwo = Convert.ToInt32(Console.ReadLine());

			return [valueOne, valueTwo];
        }

		public override int CalculateValue() 
		{ 
			int[] valuesArray = EnterValues();

			(int numOne, int numTwo) = (valuesArray[0], valuesArray[1]);

			return numOne + numTwo;

        }
	}
}
