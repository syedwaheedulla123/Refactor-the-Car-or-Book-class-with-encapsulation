using System;

namespace Refactor_the_Car_or_Book_class_with_encapsulation
{
    public class Car
    {

        private string _name;
        private double _price;
        private int _milage;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }
        public int Milage
        {
            get { return _milage; }
            set
            {
                _milage = value;
            }
        }
        public void MyCar(string name, double price, int milage)
        {
            Name = name;
            Price = price;
            Milage = milage;
        }
        public void Display()
        {
            Console.WriteLine($"Car name is {Name}, price is {Price} and mileage is {Milage} kms");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Car obj = new Car();

            obj.MyCar("Toyota", 45000, 15);
            obj.Display();
            obj.Name = "Tata";
            obj.Price = 50000;
            obj.Milage = 11;
            obj.Display();
        }
    }
}
