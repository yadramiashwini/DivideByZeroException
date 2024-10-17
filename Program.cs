namespace DivideByZeroException
{
    public class DivByzero
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter a and b val");
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int val = a / b;
                    Console.WriteLine(val);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
