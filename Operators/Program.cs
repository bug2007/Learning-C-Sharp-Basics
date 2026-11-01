namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a / b); //output: 3. (float) a / (float) b = 3.3333....

            var x = 1;
            var y = 2;
            var z = 3;

            Console.WriteLine(z > y && z > x);  // OR: ||
        }
    }
}