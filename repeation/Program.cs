using System;
using System.Linq;

namespace christmas_tree
{
    class Program
    {
        public static void PrintNumber(int number)
        {
            for (int x = 0; x <= number;)
                Console.WriteLine(number--);
        }



        static void Main(string[] args)
        {
            Animal myCat = new Cat();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            //myCat.AnimalSound();
            //myDog.AnimalSound();

            Console.WriteLine("What size you want the tree to be, enter a number: ");

            int num = Convert.ToInt32(Console.ReadLine());


            if (num <= 50)
            {
                for (int count1 = 0; count1 < num; count1++)
                {   //draw tree height
                    for (int count2 = 0; count2 < num - count1 - 1; count2++)
                    { //draw white space
                        Console.Write(" ");
                    }
                    for (int count3 = 0; count3 < count1 * 2 + 1; count3++)
                    { //drint stars(leavse)
                        Console.Write("+");
                    }
                    Console.WriteLine();
                }
                for (int count4 = 0; count4 < 2; count4++)
                {  //draw leg of tree
                    for (int count5 = 0; count5 < num - 2; count5++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("+++");
                }
                Console.WriteLine("\n\n\n");
            }
            else
            {
                Console.WriteLine("number is too big");
            }


        }


    }
}
