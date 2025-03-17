using System;

namespace CalculatorSystem
{
	public class Subtract : Calculate
	{
		public override int CalculateValue(int valueOne, int valueTwo) 
		{
			return valueTwo - valueOne;
		}
	}
}
