using System;

namespace ConstructorExample
{
    // Class to demonstrate constructors
    class Person
    {
        // Fields of the class
        public string name;
        public int age;

        // Default Constructor (no parameters)
        public Person()
        {
            name = "Unknown";  // Default value
            age = 0;           // Default value
            Console.WriteLine("Default Constructor: Person created with default values.");
        }

        // Parameterized Constructor (with parameters)
        public Person(string personName, int personAge)
        {
            name = personName;  // Set the name
            age = personAge;    // Set the age
            Console.WriteLine("Parameterized Constructor: Person created with provided values.");
        }

        // Constructor with `this` keyword (clarifies fields and parameters)
        public Person(string name, int age)  // parameters with same name as fields
        {
            this.name = name;  // `this` refers to the field, while name is the parameter
            this.age = age;    // `this` refers to the field, while age is the parameter
            Console.WriteLine("Constructor with 'this' keyword used to differentiate parameters and fields.");
        }

        // Method to display the person's details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects using different constructors
            Person person1 = new Person();  // Calls the default constructor
            person1.DisplayDetails();  // Should display default values

            Person person2 = new Person("Alice", 30);  // Calls the parameterized constructor
            person2.DisplayDetails();  // Should display provided values

            Person person3 = new Person("Bob", 25);  // Calls the constructor with `this` keyword
            person3.DisplayDetails();  // Should display provided values

            // Wait for user input before closing
            Console.ReadLine();
        }
    }
}
