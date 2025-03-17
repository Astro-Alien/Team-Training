using System;

namespace CalculatorSystem
{
	public class Division : Calculate
	{
		public override int CalculateValue(int valueOne, int valueTwo)
		{
            if (valueTwo == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return valueOne / valueTwo;
		}
	}
}
