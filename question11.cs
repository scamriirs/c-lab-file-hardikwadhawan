using System;

namespace ClassAndObjectExample
{
    // Define a class named "Car"
    class Car
    {
        // Fields of the class
        public string make;
        public string model;
        public int year;

        // Constructor to initialize the fields
        public Car(string carMake, string carModel, int carYear)
        {
            make = carMake;
            model = carModel;
            year = carYear;
        }

        // Method to display car details
        public void DisplayCarDetails()
        {
            Console.WriteLine($"Car Details: {year} {make} {model}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of the "Car" class
            Car car1 = new Car("Toyota", "Corolla", 2021);
            Car car2 = new Car("Honda", "Civic", 2020);

            // Calling the method to display car details
            car1.DisplayCarDetails();
            car2.DisplayCarDetails();

            // Wait for the user to press a key before closing the program
            Console.ReadLine();
        }
    }
}
