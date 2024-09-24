namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(x * i);
            }
        }
    }
}
