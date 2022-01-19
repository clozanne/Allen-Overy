using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allen_Overy
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup();
            Question1();
            Question2();
            Question3();
            Question4();
            Tenants tenants = new Tenants();
            Question6();
            Question7();
            Question8();

            int Setup()
            {
                int min = 0;
                int max = 100;

                Random random = new Random();
                int number = random.Next(min, max);
                return number;
            }

            void Question1()
            {
                Console.WriteLine("Press Enter to generate a random number between 0-100:");
                Console.ReadLine();

                int r1 = Setup();
                Console.WriteLine("1) Random Number is: " + r1);

                Console.ReadLine();


            }

            void Question2()
            {
                Console.WriteLine("Please press enter:");
                Console.ReadLine();
                Random random = new Random();

                int r2 = random.Next();
                int r3 = random.Next();
                int r4 = r3 - r2;
                Console.WriteLine("2) Random number 1 is: " + r2 + " ; Random number 2 is:" + r3 + "; The difference is: " + r4);
                Console.ReadLine();
            }

            void Question3()
            {
                Console.WriteLine("3) List between 0 & 100 of 15 random numbers is [");
                Random rnd = new Random();

                List<int> listOfInt = new List<int>();

                for (int j = 0; j < 15; j++)
                {
                    //listOfInt.Add();
                    Console.WriteLine(+rnd.Next(100));//returns random integers < 10
                }
                Console.WriteLine("]");
                Console.ReadLine();
            }

            void Question4()
            {

                Console.WriteLine("This would be done by creating object of listofint in question three, and adding to the list within the for loop and then taking list.average");
                Console.ReadLine();
            }

            void Question6()
            {
                Console.WriteLine("The names of the tenants are:");
                Console.ReadLine();

            }

            void Question7()
            {
                Console.WriteLine("This would be done using Linq query and .where after deserializing the json");
                Console.ReadLine();

            }
            void Question8()
            {
                Console.WriteLine("Again this would be done with linq query and selecting all pets from deserialized json using newtonsoft");
                Console.ReadLine();
            }
        }
    }
}

