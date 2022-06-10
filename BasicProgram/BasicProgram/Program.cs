namespace BasicProgram
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number for Relative Problem.\n");
            Console.WriteLine("1 for Flip Coin and Print Percentage of Heads and Tails");
            Console.WriteLine("2 for Leep Year");
            Console.WriteLine("3 for Power of 2");
            Console.WriteLine("4 for Harmonic Number");
            Console.WriteLine("5 for Factors");
            Console.WriteLine("6 for Compute Quotient and Remainder");
            Console.WriteLine("7 for Swap Two Numbers");
            Console.WriteLine("8 for Check Whether a Number is Even or Odd");
            Console.WriteLine("9 for Check Whether an Alphabet is Vowel or Consonant");
            Console.WriteLine("10 for Find the Largest Among Three Numbers");

            int Problem = Convert.ToInt32(Console.ReadLine());

            switch (Problem)
            {
                
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Leap_Year();
                    break;
            }
        }
    }
}