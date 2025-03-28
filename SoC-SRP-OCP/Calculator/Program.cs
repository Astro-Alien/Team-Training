namespace CalculatorSystem
{ 

    class Progam
    {
        public static void Main(string[] args) {
            Calculate sumInstance = new Addition();
            int sumResult = sumInstance.CalculateValue(5, 2);

            Console.WriteLine(sumResult);

            Calculate subInstance = new Subtract();
            int subResult = subInstance.CalculateValue(5, 5);

            Console.WriteLine(subResult);


            Calculate divInstance = new Division();
            int divResult = divInstance.CalculateValue(12, 2);

            Console.WriteLine(divResult);

            Calculate mulInstance = new Multiplication();
            int mulResult = mulInstance.CalculateValue(5, 2);

            Console.WriteLine(mulResult);

            Calculate binToDecInstance = new BinToDec();

            int binToDecResult = binToDecInstance.CalculateValue();

            Console.log(binToDecResult);

        }
    }

}