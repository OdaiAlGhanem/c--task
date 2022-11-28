using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _28_11_oop
{
    public class Car 
    {
        public int year;
        public string Type;
        public int Price;
        public string model;
        public int Palletnumber;
        public string color;

        public void start()
        {
            Console.WriteLine("Do you want to start the engin? yes/no");

            string start = Console.ReadLine().ToLower();
            if (start == "yes")
            {

                Console.WriteLine("Engine is ON ");

            }
            else if (start == "no")
            {
                Console.WriteLine("Engine is OFF");
            }
        }

    }
    public class bmw : Car 
    {
        public bmw(int CarYear, string CarType, int CarPrice, string CarModel, int CarPalletnumber, string CarColor)
        {
            year = CarYear;
            Type = CarType;
            Price = CarPrice;
            model = CarModel;
            Palletnumber = CarPalletnumber;
            color = CarColor;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car odai = new bmw(2020, "bmw", 15000, "M5", 300001, "black");
            
            Console.WriteLine("Car year :" + odai.year + "\n" + "Car type :" + odai.Type + "\n" + "Car price :" + odai.Price + "\n" + "Car model :" + odai.model + "\n" + "Car pattelnumber :" + odai.Palletnumber + "\n" + "Car color :" + odai.color);
           odai.start(); 
        
        }
    }
}