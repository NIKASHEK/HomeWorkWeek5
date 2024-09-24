namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3
            var x = Console.ReadLine();
            var y = Console.ReadLine();
            var someInt = x;
            x = y;
            y = someInt;
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
