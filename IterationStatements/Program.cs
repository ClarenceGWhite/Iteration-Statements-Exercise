using System.Text;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COUNTING BACKWARDS EXERCISE  --");
            Console.WriteLine("This will count from 1,000 backwards to -1,000...");
            Thread.Sleep(2500);
            Print1KandBack();

            Console.WriteLine();
            Console.WriteLine("INCREMENT BY 3 EXERCISE  --");
            Console.WriteLine("This will increment by 3 to 999...");
            Thread.Sleep(2500);
            IncrementBy3();

            Console.WriteLine();
            Console.WriteLine("NUMERIC EQUALITY CHECK --");
            Console.WriteLine("Enter two numbers separated by a comma to see if they are equal...");
            string inputEqual = (Console.ReadLine());
            string str1 = inputEqual.Split(',')[0];
            string str2 = inputEqual.Split(',')[1];
            int a = Convert.ToInt32(str1);
            int b = Convert.ToInt32(str2);
            Console.WriteLine($"Does {str1} equal {str2}???");
            Console.WriteLine(CheckEqual(a, b));

            Console.WriteLine();
            Console.WriteLine("EVEN/ODD NUMBER CHECK --");
            Console.WriteLine("Enter a number to see if it's value is Even or Odd...");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Is {x} an Even Value???");
            Console.WriteLine(CheckEven(x));

            Console.WriteLine(); 
            Console.WriteLine("NUMERIC POSITIVE/NEGATIVE CHECK --");
            Console.WriteLine("Enter a number to see if it's value is Positive or Negative...");
            int posNegCheck = int.Parse(Console.ReadLine());
            Console.WriteLine($"Is {posNegCheck} a Positive Value???");
            Console.WriteLine(CheckPlusMinus(posNegCheck));
                            
            Console.WriteLine();
            Console.WriteLine("VOTING AGE CHECKER --");
            Console.WriteLine("Please enter your current age...");
            int voter = int.Parse(Console.ReadLine());
            Console.WriteLine(VotingAge(voter));

            Console.WriteLine();
            Console.WriteLine("Checking If Number in a Numeric Range Exercise  --");
            Console.WriteLine("Enter a number to see if it is between -10 and 10...");
            int sendVal = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberRange(sendVal));


         
            Console.WriteLine();
            Console.WriteLine(MultTable(2,3)); 

        }



        public static void Print1KandBack()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);

            }

        }
        public static void IncrementBy3()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }


        }
        public static bool CheckEqual(int a, int b)
        {
            var check = (a == b) ? true : false;
            
            return check;

        }
        public static bool CheckEven(int x)
        {
            var test = (x % 2);
            bool oddEven;
            {
                if (test == 0)
                    oddEven = true;
                else
                    oddEven = false;

                return oddEven;
            }

        }
        public static bool CheckPlusMinus(int y)
        {
            bool posNeg;
            {
                if (y > 0)
                    posNeg = true;
                else
                    posNeg = false;
               
                return posNeg;


            }
        }
        public static string VotingAge(int z)
        {
            string voter;
            {
                if (z >= 18)
                    voter = ("Congratulations!  You are old enough to vote");
                else
                    voter = ("Sorry!  You are too young to vote");

                return voter;

            }

        }
        public static string NumberRange(int s)
        {
            string inRange;
            {
               
               
                 if (s >= -10 && s <= 10)
                    inRange = ("Your number is in the Numeric Range");
                 else
                    inRange = ("Your number is not in the Numeric Range");

                 return inRange;
                
                    
            }
        }
        public static string MultTable(int d, int e)
        {
            int baseNum, multFactor;
            Console.WriteLine("Enter the base number to multipy...");
            baseNum = int.Parse(Console.ReadLine());
            StringBuilder sb = new();

            for (multFactor = 1; multFactor <= 12; multFactor++)
            {
            sb.AppendLine($"{baseNum} * {multFactor} = {baseNum * multFactor}");
         
            }

            return sb.ToString();



        }
    }
}







            
    
        



 

    

      
 
   






