namespace Topic_7._2___For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Task #1 - Ten Times");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i + "." + "Pizza is delicious!");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Task #2 - Counting Machine");
            //int number;
            //Console.WriteLine("What do you want me to count to? ");
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 1; i <= number; i += 1)

            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            Console.WriteLine("Task #3 - Counting Machine Revisited");
            int start, end, step;

            Console.Write("Count from: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Count to: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Count by: ");
            step = Convert.ToInt32(Console.ReadLine());

            if (step > 0) 
            {
                for (int i = start; i <= end; i += step)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Infinite Loop Error");
            }
        }
    }
}
