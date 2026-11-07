var firstName = "Mosh";  // or string firstName = "Mosh"; or String firstName = "Mosh"; or var firstName = new String("Mosh"); because String is a class
var lastName = "Hamedani";

var fullName = firstName + " " + lastName;

var myFullName = string.Format("My name is {0} {1}", firstName, lastName);  // Fomrat is a static method. static methods can be accessed by a class (e.g String class) without the need to create an instance of that class

var names = new string[3] {"Jack", "John", "Mary" };

var formattedNames = string.Join(",", names);

Console.WriteLine(formattedNames);

var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
Console.WriteLine(text);

var verbatimString = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder20";

Console.WriteLine(verbatimString);