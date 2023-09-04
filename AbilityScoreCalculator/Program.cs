using System;

namespace AbilityScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();

                Console.WriteLine("Calculated ability scord: " + calculator.Score);
                Console.WriteLine("Press Q to Quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }

        /// <summary>
        /// 判斷輸入的整數
        /// </summary>
        /// <param name="lastUsedValue"></param>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string str = Console.ReadLine();
            if(int.TryParse(str, out int value))
            {
                Console.WriteLine("using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        /// <summary>
        /// 判斷輸入的double
        /// </summary>
        /// <param name="lastUsedValue"></param>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string str = Console.ReadLine();
            if (double.TryParse(str, out double value))
            {
                Console.WriteLine("using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
