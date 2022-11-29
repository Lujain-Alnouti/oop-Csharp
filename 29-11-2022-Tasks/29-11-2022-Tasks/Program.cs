using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _29_11_2022_Tasks
{
    class Emp
    {
        protected string name;
        protected DateTime birth;
        protected int ID;

        public Emp() { }
        public Emp(string name, DateTime birth, int iD)
        {
            this.name = name;
            this.birth = birth;
            ID = iD;
        }

        public virtual void YourAge()
        {
            int x = Convert.ToInt32(DateTime.Now.Year);
            int b = Convert.ToInt32(birth.Year);
            int y = x - b;
            //Console.WriteLine("Your Age = " + y);
            //int x1 = Convert.ToInt32(DateTime.Now.Year- birth.Year);
            int m1 = Convert.ToInt32(((DateTime.Now - birth).TotalDays % 365.242199) / 30)-1;
            int d1 = Convert.ToInt32(((DateTime.Now - birth).TotalDays % 365.242199) % 30)-2;
            Console.WriteLine("Your Age = " + y + " Years " + m1 + " Months " + d1 + " Days ");
        }
        public virtual void Print()
        {
            Console.WriteLine("Wellcome " + name + " Employee With ID = " + ID);
            Console.WriteLine("Your Birth-Date :  " + birth + " Year ");
            Console.Write("And ");
            YourAge();
            
        }
    }
    class Manager : Emp {
        public Manager(string name, DateTime birth, int iD):base( name,  birth,  iD) { }

        public override void YourAge()
        {
            base.YourAge();
            Console.WriteLine("MANAGER .....");

        }
        public override void Print()
        {
            Console.WriteLine("Wellcome " + name + " MANAGER  With ID = " + ID);
            Console.WriteLine("Your Birth-Date :  " + birth + " Year M");
            Console.Write("And, ");
            YourAge();

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(2000, 08, 07);
            Emp e = new Emp("Lujain", birthday, 134093);
            e.Print();
            Console.WriteLine("---------------------------");
            DateTime birthday2 = new DateTime(1993, 09, 03);
            Emp m = new Manager("Ahmad", birthday2, 156324);
            m.Print();

            DateTime birthday3 = Convert.ToDateTime(Console.ReadLine());
            Emp m1 = new Manager("Ahmad", birthday3, 156324);
            m1.Print();
        }
    }
}
