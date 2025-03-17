using System;

namespace CalculatorSystem
{
	public class Multiplication : Calculate
	{
		public override int CalculateValue(int valueOne, int valueTwo)
		{
			return valueTwo * valueOne;
		}
	}
}
