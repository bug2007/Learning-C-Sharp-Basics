namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit type converstion
            byte b = 1;
            int i = b;

            //explicit type conversion: cast
            int x = 1000;
            byte y = (byte) x; // maximum we can store in a byte is 255, not 1000. some of the bits will be lost

            //non-compatible types (cant use casting)
            var text = "1234";
            int number  = Convert.ToInt32(text);

            //handling exceptions
            try
            {
                var text2 = "1234";
                byte number2 = Convert.ToByte(text2);
            }

            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}