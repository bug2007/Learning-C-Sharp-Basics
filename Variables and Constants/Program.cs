namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // can just use var instead of the data types and csharp will infer from the assigned data e.g var totalPrice = 20.95f;
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A'; // only single quote for a char
            string firstName = "Mosh";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // format string. output: 0 255

            const float Pi = 3.14f; // cant change value later

        }
    }
}