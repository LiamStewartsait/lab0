using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Low number: ");
            int low = Int32.Parse(Console.ReadLine());
            Console.WriteLine("High number: ");
            int high = Int32.Parse(Console.ReadLine());
            Console.WriteLine("difference between the low and high " + (high-low));

            Console.WriteLine("Enter a positive low number");
            low = -1;
            while (low <0)
            {
                low = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a number higher than the low number");
            high = 0;
            while (high <= low)
            {
                high = Int32.Parse(Console.ReadLine());
            }
            List<int> between = new List<int>();
            for(int i = low; i <= high; i++)
            {
                between.Add(i);
            }

            using (StreamWriter sw = new StreamWriter("numbers.txt"))
            {
            for (int i = high-1; i > low; i--)
                {
                    sw.WriteLine(i);
                }
            }

            string temp = getsum().ToString();

            Console.WriteLine(temp);
            /*
             *Use methods get and validate the users input.
            Read the numbers back from the file and print out the sum of the numbers.
            Use a List instead of an array variable to store the numbers.
            Use the double data type instead of the int data type.
            Print out the prime numbers between low and high.
            Write a method that takes in a number and returns true if it is a prime number.
            You may need to use the modulus operator. 
            
            K imma be real i don't wanna do this stuff, i can code in c# as the rest of this has shown
            but i'd rather not change the list to an array just to use a list later.
            it's not hard, it would be like int[] between = new int[high]
            and then the for loop would be nearly identical just there would need to be an index variable
            so like int index = 0 
            between[index] = i;
            index++;
            that sort of thing,

            and like for the prime number thing, i get the intent is to prove we know how to use modulus
            but like i don't want to have to do all that logic
            */
            Console.ReadLine();
        }
        public static double getsum()
        {
            StreamReader sr = new StreamReader("numbers.txt");
            string line = sr.ReadLine();

            double sum = 0;

            while (line != null)
            {
                sum += Int32.Parse(line);

                line = sr.ReadLine();
            }
            sr.Close();
            return sum;

        }
    }
}
