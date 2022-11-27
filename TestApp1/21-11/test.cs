using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11
{
    internal class test
    {
        static void Main(string[] args)
        {
            //test 

            ////c# Methods ToUpper() and ToLower(),
            //string txt = "Hello World";
            //Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            //Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            ////C# String Concatenation 
            //string firstName = "odai ";
            //string lastName = "alghanem";
            //string name = firstName + lastName;
            //Console.WriteLine(name);

            //string firstName1 = "odai";
            //string lastName1 = "alghanem";
            //string name1 = string.Concat(firstName1, lastName1);
            //Console.WriteLine(name1);

            ////adding numbers
            //int x = 10;
            //int y = 20;
            //int z = x + y;
            //Console.WriteLine(z);

            ////adding string
            //string l = "10";
            //string m = "20";
            //string n = l + m;
            //Console.WriteLine(c);




           // task 1

            Console.WriteLine("enter the number :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 < number2)
            {
                Console.WriteLine("the smaller number is :" + number1);
            }
            else
            {
                Console.WriteLine("the smaller number is :" + number2);
            }



           // task 2

            Console.WriteLine("enter the number :");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number3 < 0)
            {
                Console.WriteLine("the number is negative:" + number3);
            }
            else
            {
                Console.WriteLine("the number is posetive :" + number3);
            }



           // task3

            int x = 0;
            int y = -1;
            int z = 4;
            if (x > y && x > z)
            {
                if (y > z)
                {
                    Console.WriteLine(x + ", " + y + ", " + z);
                }
                else
                {
                    Console.WriteLine(x + ", " + z + ", " + y);
                }
            }
            else if (y > x && y > z)
            {
                if (x > z)
                {
                    Console.WriteLine(y + ", " + x + ", " + z);
                }
                else
                {
                    Console.WriteLine(y + ", " + z + ", " + x);
                }
            }
            else if (z > x && z > y)
            {
                if (x > y)
                {
                    Console.WriteLine(z + ", " + x + ", " + y);
                }
                else
                {
                    Console.WriteLine(z + ", " + y + ", " + x);
                }
            }

            //task 4

            int a = -5;
            int b = -2;
            int c = -6;
            int d = 0;
            int e = -1;
            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                Console.WriteLine("the max number is :" + a);
            }
            if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
            {
                Console.WriteLine("the max number is :" + b);
            }
            if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                Console.WriteLine("the max number is :" + c);
            }
            if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                Console.WriteLine("the max number is :" + d);
            }
            if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
            {
                Console.WriteLine("the max number is :" + e);
            }


           // task5

            Console.WriteLine("input kilometers per hour:  ");
            double killo = Convert.ToInt32(Console.ReadLine());
            double mills = killo * 0.621371;
            Console.WriteLine(mills + "miles per hour");

           // task6

            Console.WriteLine("input houres : ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input minutes : ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total :" + (h * 60) + m + "minutes");


           // task7


            Console.WriteLine("Enter minutes  : ");
            double mins = Convert.ToDouble(Console.ReadLine());

            int houres = (int)mins / 60;
            int minutes = (int)mins % 60;
            Console.WriteLine("houres : " + houres + " : minutes " + minutes);

            //task8
            string[] weekDays2 = { "Sunday", "Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Satarday" };

            Console.WriteLine("the day of (Sunday) is :" + weekDays2[0].Substring(0, 3));
            Console.WriteLine("the day of (Monday) is :" + weekDays2[1].Substring(0, 3));
            Console.WriteLine("the day of (Tuesday) is :" + weekDays2[2].Substring(0, 3));
            Console.WriteLine("the day of (Wednsday) is :" + weekDays2[3].Substring(0, 3));
            Console.WriteLine("the day of (Thursday) is :" + weekDays2[4].Substring(0, 3));
            Console.WriteLine("the day of (Friday) is :" + weekDays2[5].Substring(0, 3));
            Console.WriteLine("the day of (Satarday) is :" + weekDays2[6].Substring(0, 3));
        }
    }
}
