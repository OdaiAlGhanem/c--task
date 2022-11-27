using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test 1
            //    Console.WriteLine("Foreach Loop on Arrays ");
            //    int j = 0;
            //    string[] Names = { "Momen", "odai", "Qaiz", "Asharaf", "Hassan" };

            //    foreach (string i in Names)
            //    {
            //        if (Names[j] == "Asharaf") { break; }
            //        Console.WriteLine(Names[j]);
            //        j++;

            //    }



            //    Console.WriteLine("\n");

            //    Console.WriteLine("For Loop on Arrays ");

            //    string[] objects = { "Volvo", "BMW", "Ford", "Mazda" };

            //    for (int i = 0; i < objects.Length; i++)
            //    {

            //        Console.WriteLine(objects[i] + " ");

            //    }


            //task1 
            //int[] ARR = { 1, 7, 9, 45 };

            //string[] arr2 = { "Str", "alex", "moh" };

            //string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            //task2

            //String[] fruits = { "Tomato", "Banana", "Watermelon" };
            //Console.WriteLine("the index of Banana :" +"  " + Array.IndexOf(fruits ,"Banana"));
            //Console.WriteLine("the index of Tomato :" + "  " + Array.IndexOf(fruits , "Tomato"));

            //task3

            //Console.WriteLine("Foreach Loop on Arrays ");
            //string[] food = { "Mansaf", "Maqlubeh", "Kabseh", "Msakhan", "Burger" };

            //foreach (string i in food)
            //{
            //    Console.WriteLine(i);

            //}

            //Console.WriteLine("\n");

            //Console.WriteLine("For Loop on Arrays ");
            //string[] sports = { "Drift", "Diving", "football" };

            //for (int i = 0; i < sports.Length; i++)
            //{

            //    Console.WriteLine(sports[i] + " ");

            //}


            //Console.WriteLine("\n");
            //Console.WriteLine("Foreach Loop on Arrays ");
            //string[] movies = { "Royalteen", "Smile", "Carter", "The Gray Man" };

            //foreach (string i in movies)
            //{
            //    Console.WriteLine(i);

            //}


            //task4

            //int x ;
            //int y ;
            //int z ;    

            //Console.WriteLine("Input the number :" + " "  );
            //x =Convert.ToInt32 ( Console.ReadLine());

            //Console.WriteLine("Input the number :" + " ");
            //y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input the number :" + " ");
            //z = Convert.ToInt32(Console.ReadLine());
            //int sum = x + y + z;
            //Console.WriteLine(sum);  


            //task5
            //int sum = 0;
            //for(int i = 1; i <= 100; i++)
            //{
            //    if (i%2 != 0 )
            //    {
            //        sum += i;

            //    }

            //}
            //Console.WriteLine(sum);     


            //task6

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 4 - i; j > 0; j--)
                {

                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();

                //int row = 4;
                //for (int i = 0; i <= 4; i++)
                //{
                //    for (int j = 0; j < row - i; j++)
                //    {
                //        Console.Write(" ");
                //    }
                //    for (int j = 0; j <= i; j++)
                //    {
                //        Console.Write("* ");
                //    }
                //    Console.WriteLine();

                //    int f = 1;
                //    for (int i = 0; i < 4; i++)
                //    {

                //        for (int j = 4 - i; j > 0; j--)
                //        {
                //            Console.Write(" ");
                //        }
                //        for (int j = 0; j <= i; j++)
                //        {
                //            Console.Write(f + " ");
                //            f++;

                //         }
                //    Console.WriteLine();
                //
                //    double number1, number2, number3, number4;

                //    Console.Write("Enter the First number: ");
                //    number1 = Convert.ToDouble(Console.ReadLine());

                //    Console.Write("Enter the Second number: ");
                //    number2 = Convert.ToDouble(Console.ReadLine());

                //    Console.Write("Enter the third number: ");
                //    number3 = Convert.ToDouble(Console.ReadLine());

                //    Console.Write("Enter the fourth number: ");
                //    number4 = Convert.ToDouble(Console.ReadLine());

                //    double result = (number1 + number2 + number3 + number4) / 4;
                //    Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
                // number1, number2, number3, number4, result);
            }     }
    }
}

       