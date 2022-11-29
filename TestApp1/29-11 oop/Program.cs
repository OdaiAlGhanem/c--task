using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _28_11_oop
{
   class Employee
    {
        public string Name;
        public int Birthofdate;
        public int Id;

        public Employee() { }
  
        public Employee(string EmployeeName, int EmployeeBirthofdate, int EmployeeId)
        {
            Name = EmployeeName;
            Birthofdate = EmployeeBirthofdate;
            Id = EmployeeId;

        }
        public virtual void Age()
        {
            Console.WriteLine( "Employee name is " + Convert.ToString(2022- Birthofdate));
        }
    }

   class  Owner : Employee
   {
        public void Information ()
        {
            Console.WriteLine(Name + " "+ Birthofdate+" "+Id);
        }
        public Owner(string EmployeeName, int EmployeeBirthofdate, int EmployeeId)
        {
            Name = EmployeeName;
            Birthofdate = EmployeeBirthofdate;
            Id = EmployeeId;
        }
        public override void Age()
        {
            Console.WriteLine("Owner name is " + Convert.ToString(2022 - Birthofdate));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee odai = new Employee("OdaiAlGhanem",1993,24);
         //   odai.Age();
            Owner Khaled = new Owner("Khaled", 2000, 30);
           // Khaled.Age();
          
        }
    }
}