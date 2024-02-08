namespace GreetingApp
{
    internal class Program
    {
        static void GreetingProgram(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.Write("Enter the total number of your enrolled courses: ");
            int enrolled;
            enrolled = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book: ");
            double price;
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Total enrolled courses: " + enrolled);
            Console.WriteLine("Price of my favorite book: " + price);
        }
    }
}