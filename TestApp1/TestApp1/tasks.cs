using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp1;

namespace TestApp1
{
    internal class tasks
    {
        static void Main(string[] args)


        {
            //task 1
            Console.WriteLine("Enter your  Name");
            String yourname = Console.ReadLine();

            //task 2
            double number = 2.002;
            string str = "odai";
            char character = 'a';
            bool boo = false;
            int num = 5;
            const int a=4;
            Console.WriteLine("number is :"+number);
            Console.WriteLine("str is :" + str);
            Console.WriteLine("character is :" + character);
            Console.WriteLine("boolean is:" + boo);
            Console.WriteLine("number is :", num);
            Console.WriteLine("const is :" + a);

            //task 3

            string[] cars = { "bmw", "honda", "volvo", "kia" };
            for(int i=0; i < cars.Length; i++) 
            {
                Console.WriteLine(cars[i]);
            }

            //task 4

            Console.WriteLine("Enter your First Name");
            String FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            String LastName = Console.ReadLine();

            Console.WriteLine("Enter your birthday");
            string birthday = Console.ReadLine();
           

            Console.WriteLine("Hello {0}, {1} ,{2}",FirstName, LastName,  birthday );


            //task 5
            int[] numbers = { 1,1,2,3,4,5,6,7,8,9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
               
            }

            //task 6

            int[] numm = { 2, 5, 8 };
            int sum = 0;
            for (int i = 0; i < numm.Length; i++)
            {
                sum += numm[i];

            }

            Console.WriteLine("the numbers is : " + sum);

        }






    }

 }
