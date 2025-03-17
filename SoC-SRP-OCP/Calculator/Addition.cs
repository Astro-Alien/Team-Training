using System;
using System.Security.Policy;

namespace CalculatorSystem
{

	public class Addition : Calculate
	{
		public override int CalculateValue(int valueOne, int valueTwo) 
		{
			return valueOne + valueTwo;
		}
	}
}
