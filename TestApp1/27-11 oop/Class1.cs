using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApplication
{
    public class Personal
    {
        public int age;
        public string gender;
        public string name;
        public string email;
        public int id;
        public int phone;
      
        public Personal(int personalage, string personalgender, string personalname,  string personalemail,  int personalid, int personalphone)
        {
            age = personalage;
            if( personalage < 18 || personalage > 60 )
            {
                Console.WriteLine("age is not between 18 and 60 ");
            }
            gender = personalgender;
            name = personalname;
            email = personalemail;
            id = personalid;

            if (personalphone.Substring(0, 3) == "077" || personalphone.Substring(0, 3) == "079" || personalphone.Substring(0, 3) == "078") 
            {
                phone = personalphone;
            }
            else
            {
                Console.WriteLine("rong phone number");
            }
        }

    }
 

    class Car
    {
        static void Main(string[] args)
        {
            Personal odai = new Personal(24, "male", "odai", "alghanemodai@gmail.com", 1, 9995128);
            Console.WriteLine(odai.phone);
        }
    }
}