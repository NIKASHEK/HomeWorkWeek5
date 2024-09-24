namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nika Shekiladze  Home work 5
            //Console.WriteLine("Hello World!");

            // 1
            var enteredInt = Convert.ToInt32(Console.ReadLine());
            if(enteredInt % 5 == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}
