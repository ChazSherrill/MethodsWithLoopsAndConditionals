using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        public static void WasThoseNumBtwnMNM()
        {
            int i; 
            for ( i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WasThoseNumBtwn3to999()
        {
            
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        public static bool IsThisNThatN(int x, int y)
        {
            return x == y;
        }

        public static string OddOrEven(int y)
        {
            if (y % 2 == 0)
            {
                return "even";
            }else
            {
                return "odd";
            }
        }

        public static string WhereIsZero (int y)
        {
            if (y > 0)
            {
                return $"{y} is positively positive.";
            } else if (y < 0)
            {
                return $"{y} negatively negative.";
            } else
            {
                return "Hey you found zero.";
            }
        }

        public static string CanYouVote()
        {
            Console.WriteLine("I'm growing concerned that you don't even know your own age...if you were to try to vote they may kill you.");
            
            int number;
            string p;

            do
            {
                Console.WriteLine("let me help, tell me you're age.");
                p = Console.ReadLine();
            }
            while (int.TryParse(p, out number) == false);
            
            if (int.TryParse(p , out number))
            {
                if( number >= 18)
                {
                    return "You can def vote your 18+";
                }
                else
                {
                    return "You can't vote you'll die child";
                }
            }
            
            return "Try a number dumb dumb";
            
        }

        public static bool TenDownOrTenUp(int c)
        {
            if (c > -10)
            {
                if (c < 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void MultTable(int v)
        {
            for (int i = 1; i != 12 + 1; i++)
            {
                int p = i * v;
                Console.WriteLine($"the product of {v} and {i} is {p}.");
            }
        }

        public static int[] IntToArray(int n)
        {
            int[] array = new int[n];
            var r = new Random();
            for (int i = 0; i != array.Length; i++)
            {
                array[i] = r.Next(1, 100);
            }
            Console.WriteLine("You're random numbers are:");
            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
            return array;
        }

        public static int stringToArrayToSum (string values)
        {
            string[] tokens = values.Split(',');

            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

            int sum = 0;
            for (int i = 0; i < convertedItems.Length; i++)
            {
                sum += convertedItems[i];
            }
            return sum;
        }

        public static void cubeItUp (int n)
        {
            var c = (n * n * n);
            Console.WriteLine($"Number is: {n} and the cube of {n} is:{c}");

        }







        static void Main(string[] args)
        {
            WasThoseNumBtwnMNM();

            WasThoseNumBtwn3to999();

            Console.WriteLine("you look not so smart");
            Console.WriteLine("How about i help you determine if two numbers are the same?");
            Console.WriteLine("Pick a number por favor");
            int x;
            int y;
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("uno mas picko the number");

            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Are they Equal?");

            Console.WriteLine(IsThisNThatN(x, y));

            Console.WriteLine("You look like the kind of person that doesn't know what num is even or odd?");
            Console.WriteLine("Let me help tell me a number.");

            y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{y} is definitely {OddOrEven(y)}");

            Console.WriteLine("Maybe you also need help with what those + and - mean?");

            Console.WriteLine("Write another Number!");

            int r = int.Parse(Console.ReadLine());

            Console.WriteLine(WhereIsZero(r));

            Console.WriteLine(CanYouVote());

            Console.WriteLine("let's make it easy give me a number between -10 and 10");
            Console.WriteLine($"It is {TenDownOrTenUp(int.Parse(Console.ReadLine()))} you are smart.");

            
            Console.WriteLine("Well if we are taking it to basics then let' work on multiplication table");
            Console.WriteLine("Tell me a number and I will tell the multiplication tables through 12");

            MultTable(int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Well let's think about things a different way.");
            Console.WriteLine("give me a number and I will return an array with that many ints, or that many random numbers");
            IntToArray(int.Parse(Console.ReadLine()));
            

            Console.WriteLine("to further aid youn in your guide for number dominance. let's do some sums");
            Console.WriteLine("give me some numbers separated by commas and i'll sum them up for you");

            Console.WriteLine(stringToArrayToSum(Console.ReadLine()));
            

            Console.WriteLine("for the final work let's do some cubing");
            Console.WriteLine("just hit me with a number an I'll cube it for you");
            cubeItUp(int.Parse(Console.ReadLine()));

            Console.WriteLine("Good job! you now know all the numbers!");


        }
    }
}
