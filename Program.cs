// See https://aka.ms/new-console-template for more information

// Samuel Kiarie - Classes Practice Assignment - 05/26/2022

using Person;
namespace Person
{
    public class Person // name of the class
    {     // properties of the class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void DisplayPersons() // method of the class the printing format

        {
            Console.WriteLine("Hello, there!");
            Console.WriteLine("My name is: "+ FirstName + " " + LastName + ", " + "Email: " + Email);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); // Instatiation of a class to create an object
           
            person.FirstName = "Peter";
            person.LastName = "Carr";
            person.Email = "petercar@gmail.com";

            var Person2 = new Person(); // Second instantiation of the class

            Person2.FirstName = "Sarah"; 
            Person2.LastName = "Byod";
            Person2.Email = "Sayd@gmail.com";


            var Person3 = new Person(); // Third instantiation of the class

            Person3.FirstName = "Sam";
            Person3.LastName = "Snead";
            Person3.Email =  "s@gmail.com";


            // Code to run the method using the console
            person.DisplayPersons(); 
            Person2.DisplayPersons();
            Person3.DisplayPersons();




        }
    }
}
