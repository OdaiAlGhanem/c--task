using MyApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11_oop
{
    internal class Personal
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
            if(age<18)
            { 
                age= 18;    
            }
            if (age>60)
            {
                age= 60;
            }
            gender = personalgender;
            name = personalname;
            email = personalemail;
            id = personalid;
            phone = personalphone;

        }
        static void Main(string[] args)
        {
            Personal odai = new Personal(29, "male", "odai", "alghanemodai@gmail.com", 1, 0799995128);
            Console.WriteLine(odai.age + " " + odai.gender + " " + odai.name + " " + odai.email + " " + odai.id + " " + odai.phone);
        }
    }
}
