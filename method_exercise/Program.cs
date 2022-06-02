using System;

namespace method_exercise
{
    internal class Program
    {
        public static int Add(params int[] nums)
        {
            int sum = 0;
            foreach (int i in nums) sum += i;
            return sum;
        }
        public static int Multiply(params int[] nums)
        {
            int prod = 1;
            foreach (int i in nums) prod *= i;
            return prod;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your favorite sport: ");
            string sport=Console.ReadLine();

            age += 25;
            foreach (char c in name) if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') name = name.Replace(c, 'z');
            string newsport = (sport == "curling") ? "pickleball" : "curling";

            Console.WriteLine("So, let me get this straight...");
            Console.ReadKey();
            Console.WriteLine("Your name is " + name + " and you are " + age + " years old, and your favorite sport is "+ newsport);
            Console.ReadKey();
            Console.WriteLine("Is that correct?  Enter \"yes\" or \"no\".");
            string response=Console.ReadLine();
            if (response == "yes") Console.WriteLine("Glad we got that sorted out.  Thanks, " + name);
            else if (response == "no") Console.WriteLine("Sounds good, thanks for clarifying that.");
            else Console.WriteLine("I didn't catch that.  I'll just assume we're good.");
            Console.ReadKey();
            
            
            Console.WriteLine("\nOkay, " + name + ", it's time for some math.");
            Console.ReadKey();
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is some math: ");
            //Console.WriteLine(Add(x,y));
            Console.WriteLine($"{x} + {y} = " + Add(x, y));
            Console.WriteLine($"{x} * {y} = " + Multiply(x, y));

            Console.ReadKey();

            Console.WriteLine("\nNow let's do the same thing, but with more numbers: ");
            Console.ReadKey();
            Console.WriteLine($"{x} + {x} + {y} + {y} = " + Add(x, x, y, y));
            Console.WriteLine($"{x} * {x} * {y} * {y} = " + Multiply(x, x, y, y));
            Console.ReadKey();

            Console.WriteLine("\nGoodbye!");
            Console.ReadKey();
            return;
        }

    

    }
}
