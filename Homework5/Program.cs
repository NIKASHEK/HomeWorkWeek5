namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nika Shekiladze  Home work 5
            //Console.WriteLine("Hello World!");

            // 1
            //var enteredInt = Convert.ToInt32(Console.ReadLine());
            //if(enteredInt % 5 == 0)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");

            // 2
            var enteredInt1 = Convert.ToInt32(Console.ReadLine());
            var enteredInt2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(enteredInt1 + enteredInt2);
            Console.WriteLine(enteredInt1 * enteredInt2);
            if (enteredInt1 >= enteredInt2)
            {
                Console.WriteLine(enteredInt1 - enteredInt2);
                if(enteredInt2 == 0)
                    Console.WriteLine("Not Allowed To Divide By Zero");
                else
                    Console.WriteLine(enteredInt1 / enteredInt2);
            }
            else
            {
                Console.WriteLine(enteredInt2 - enteredInt1);
                if(enteredInt1 == 0)
                    Console.WriteLine("Not Allowed To Divide By Zero");
                else
                    Console.WriteLine(enteredInt2 / enteredInt1);
            }
        }
    }
}
