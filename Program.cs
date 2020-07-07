using System;

namespace Lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, squared, cubed;
            bool began = true;
            string cont;

            Console.WriteLine("Learn your squares and cubes!");

            while (began)
            {
               
                Console.WriteLine("Enter an integer:");
                num = Convert.ToInt32(Console.ReadLine()); //1290

                if (num > 1290.1)
                {
                    Console.Write("\n");
                    Console.WriteLine("This number is too big to fit. Pick a smaller integer");
                    began = true;
                }
                else if (num <= 0)
                {
                    Console.Write("\n");
                    Console.WriteLine("You entered 0 or a negative integer. Pick a positive integer");
                }
                else
                {
                    Console.Write("\n");

                    Console.WriteLine("Number\t\tSquared\t\tCubed");
                    Console.WriteLine("=======\t\t=======\t\t=======");

                    for (int a = 1; a <= num; a++)
                    {
                        squared = a * a;
                        cubed = (a * a) * a;
                        Console.WriteLine($"{a,7}  {squared, 14}  {cubed, 14}");
                    }
                }

                Console.Write("\n");

                Console.WriteLine("Continue? (y/n)");
                cont = Console.ReadLine();

                Console.Write("\n");

                if (cont == "n")
                {
                    Console.Write("\n");
                    Console.WriteLine("Thank you!");
                    began = false;
                }
                else if (cont == "y")
                {
                    began = true;
                }                             
            } 
        }
    }
}
