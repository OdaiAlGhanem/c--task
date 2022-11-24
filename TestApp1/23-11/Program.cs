    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _23_11
    {
        internal class Program
        {
        //task1==================================================================
        
        static void Task1()
        {
            int sum = 0;
            int entries = 0;
            Console.WriteLine("Enter 10 numbers each on a line:");
            for (int i = 0; i < 10; i++)
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                sum += num1;
                entries++;
            }
            Console.WriteLine($"The summation is : {sum}");
            Console.WriteLine($"The average is : {sum / entries}");
        }


        //task2=====================================================================
            static void task2()
        {
            Console.WriteLine("Please Enter The Numbers of terms");
            cube(Convert.ToInt32(Console.ReadLine()));
        }
        static void cube(int nTerm)
        {
            for (int i = 1; i <= nTerm; i++)
            {
                int pow = i * i * i;
                Console.WriteLine(" Numbers is:" + i + " and cube of The " + i + " is: " + pow);
            }
        }

        //task3============================================================================
        static void Task3(int[] years)
        {
            int[] arr = { };
            for (int i = 0; i < years.Length; i++)
            {

                if (years[i] > 1950)
                {
                    Console.WriteLine(years[i]);
                }
                else
                {
                    continue;
                }
            }
        }
        //task4================================================
        static void task4()
        {
            Console.WriteLine("please Enter Your age in Years");
            double yourageindays = ageindays(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(yourageindays);


        }
        static double ageindays(int age)
        {

            return age * 362;
        }
        //task5=======================================================
        static void task5()
        {
            Console.WriteLine("Please Enter The Number of Chicken ");
            int numberofchicken = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Number of Cows ");
            int numberofCows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Number of Pigs ");
            int numberofPigs = Convert.ToInt32(Console.ReadLine());

            int numberoflegs = animals(numberofchicken, numberofCows, numberofPigs);
            Console.WriteLine(numberoflegs);

        }
        static int animals(int chickens, int cows, int pigs)
        {

            int numberof_Legs = chickens * 2 + cows * 4 + pigs * 4;
            return numberof_Legs;
        }
        //task6=======================================================
        static void task6()
        {
            
            
                string[] users = { "odai", "ali", "eisa", "ahmad", "al", "ghanem" };
                Console.WriteLine("Please Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine(logIn(users, name));

        }

        static string logIn(string[] arr, string name)
        {
            bool flaf = false;
            foreach (string s in arr)
            {
                if (name == s)
                {
                    flaf = true;
                }
            }
            if (flaf == true)
            {
                return "Pass";
            }
            else
            {
                return "faill";
            }

        }
        //task7=======================================================
        static void Task7(int num7, int num8)
        {
            int ting = 1;
            for (int i = 1; i <= num8; i++)
            {
                ting *= num7;
            }
            Console.WriteLine(ting);
        }
        //task8=======================================================
        static void Task8()
        {
            Console.WriteLine("Enter a year from 1900 to 2024: ");
            int leap = Convert.ToInt32(Console.ReadLine());
            if (leap >= 1900 && leap <= 2024)
            {
                if (leap == 1900)
                {
                    Console.WriteLine($"{leap} is not a leap year");
                }
                else if (leap % 4 == 0)
                {
                    Console.WriteLine($"{leap} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{leap} is not a leap year");
                }
            }
        }
        //task9=======================================================
        static void Task9()
        {
            Console.WriteLine("Enter a number: ");
            int num9 = Convert.ToInt32(Console.ReadLine());
            if (num9 == 2 || num9 == 3)
            {
                Console.WriteLine($"{num9} is a prime number");
            }
            else if (num9 % 2 == 0)
            {
                Console.WriteLine($"{num9} is not a prime number");
            }
            else
            {
                for (int i = 3; i < 10; i++)
                {
                    if (num9 % i == 0)
                    {
                        Console.WriteLine($"{num9} is not a prime number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{num9} is a prime number");
                        break;
                    }

                }
            }
        }
        //task10=======================================================
        static int Task10()
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] sentArr = sentence.Split(' ');

            return sentArr.Length;
        }
        static void Main(string[] args)
            {

            //task1
            // Task1();
            //task2
            // task2();
            //Task3
            //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            //Task3(years);
            //task4
            //task4();
            //task5
            //task5();
            // task6();
            // task7
            // Console.WriteLine("Enter a number: ");
            //int num7 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter the power: ");
            // int num8 = Convert.ToInt32(Console.ReadLine());
            // Task7(num7, num8);
            //task8
            //Task8();


            //Task9();

            //int num10 = Task10();
            //Console.WriteLine(num10);

        }
    }
    
    }
