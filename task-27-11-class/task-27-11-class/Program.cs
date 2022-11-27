using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_27_11_class
{
    class task_1{
        private string phone;
        private string name;
        private string email;
        private string Gender;
        private int age;
        private int ID;
        public task_1(string n,int a,string G,string ph,string em,int id) {

            if (a >= 18 && a <= 60) { age = a; }
            else { Console.WriteLine("Your Age Greater Than Or Less Than Validate Range 18-60"); }
            if (ph.Substring(0, 3) == "077" || ph.Substring(0, 3) == "078" || ph.Substring(0, 3) == "079" && ph.Length==10)
            { phone = ph; }
            else { phone = "Invalidate Phone Number"; }
             name = n;
             email = em;
             Gender = G;
             ID = id;

    }
        public void print_info()
        {
            Console.WriteLine("Your Name : " + name);
            Console.WriteLine("Your Age : " + age);
            Console.WriteLine("Your Gender : " + Gender);
            Console.WriteLine("Your Phone : " + phone);
            Console.WriteLine("Your Email : " + email);
            Console.WriteLine("Your ID : " + ID);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            task_1 per1 = new task_1("Ahmad", 255,"Male","0796258814","ahmad@gmail.com",547869);
            per1.print_info();

                   }
    }
}
