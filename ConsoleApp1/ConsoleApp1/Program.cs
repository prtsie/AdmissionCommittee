namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (int i = 300; i <= 400; i++)
            {
                count += i.ToString().Count(ch => ch == '3');
            }
            Console.WriteLine(count);
        }
    }
}
