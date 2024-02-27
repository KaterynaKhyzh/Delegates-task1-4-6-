namespace Delegates1
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Input number of seconds:");
                int t = int.Parse(Console.ReadLine());
                Timer timer = new Timer(() =>
                {
                    Console.WriteLine($"This method is executed every {t} seconds.");
                }, t);

            }
        }
}