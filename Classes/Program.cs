// ideally, move the class declaration to another file called Person.cs and keep the class calling in Program.cs like u have done with the Calculator

using Classes.Math;
using CSharpFundamentals;

Person john = new Person(); // or use var instead of Person
john.FirstName = "John";
john.LastName = "Smith";
john.Introduce();

Calculator calculator = new Calculator();
var result = calculator.Add(1, 2);
Console.WriteLine(result);

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}

