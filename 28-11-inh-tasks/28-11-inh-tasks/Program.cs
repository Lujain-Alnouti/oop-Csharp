using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_inh_tasks
{/*1.	Implement a Car class which has fields to store the car's make, year, Type, 
  * Price, model, Pallet No, and color
2.	Implement a constructor for the car class which takes parameters corresponding to each of the fields above and constructs an object with these values
*/
    class Car
    {
        protected string make;
        protected int year;
        protected string Type;
        protected double Price;
        protected string model;
        protected string Pallet_No;
        protected string color;
        public Car()
        {
        }
        public Car(string m, int y, string t, double p, string mo, string pall, string c)
        {
            make = m;
            year = y;
            Type = t;
            Price = p;
            model = mo;
            Pallet_No = pall;
            color = c;
        }

        public void START()
        {
            Console.WriteLine("Your Car Has Been Started ...");
        }

        public void Stop()
        {
            Console.WriteLine("Your Car Has Been Stopped ...");
        }

    }

        class Ford : Car {

        public Ford(string make, int year, string Type, double Price, string model, string Pallet_No, string color):base(make,year,Type,Price,model,Pallet_No,color)
        {
            //    this.make = make;
            //    this.year = year;
            //    this.Type = Type;
            //    this.Price = Price;
            //    this.model = model;
            //    this.Pallet_No = Pallet_No;
            //    this.color = color;
        }
        public void all_info()
            {
                Console.WriteLine("Your Car's Make in : " + make);
                Console.WriteLine("Your Car's from : " + year + " Year");
                Console.WriteLine("Your Car's Type  : " + Type);
                Console.WriteLine("Price The Car : " + Price);
                Console.WriteLine("Your Car's Model : " + model);
                Console.WriteLine("Your Car's Pallet : " + Pallet_No);
                Console.WriteLine("Your Car's Color : " + color);
            }
        }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Ford ford = new Ford("American", 2014,"Fusion", 26000, "Fusion", "1254abc", "blue");
            ford.START();
            ford.all_info();
            ford.Stop();
        }
    }
}
