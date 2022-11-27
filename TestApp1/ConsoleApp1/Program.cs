
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Personal
    {
        public int age;
        public string gender;
        public string name;
        public string email;
        public int id;
        public int phone;


        public Personal(int personalage, string personalgender, string personalname, string personalemail, int personalid, int personalphone)
        {
            age = personalage;
            if (personalage < 18 || personalage > 60)
            {
                Console.WriteLine("age is not between 18 and 60");
            }

            gender = Agender;
            name = Aname;
            email = Aemail;
            id = Aid;

            if (Aphone.Substring(0, 3) == "077" || Aphone.Substring(0, 3) == "079" || Aphone.Substring(0, 3) == "078")
            {
                phone = Aphone;
            }
            else
            {
                Console.WriteLine("rong phone number");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ahmad = new Person(90, "mail", "ahmad", "ahmad@gmail.com", 2, "55544994");
            Console.WriteLine(ahmad.phone);
        }
    }
}