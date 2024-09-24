namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 2; i < x; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i * i);
            }
        }
    }
}
