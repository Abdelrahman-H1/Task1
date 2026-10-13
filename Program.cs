using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallcharge = 25;
            int largecharge = 35;
            const double tax = 0.06;
            int estimatedays = 30;

            Console.WriteLine("Estimate for carpet cleaning service");
            Console.Write("Enter The Number of small carpets: ");
            int numsmallcarpets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            int numlargecarpets = Convert.ToInt32(Console.ReadLine());

            double totalwithnotax = (smallcharge * numsmallcarpets) + (largecharge * numlargecarpets);

            Console.WriteLine($"Price per Small carpet : {smallcharge}");
            Console.WriteLine($"Price per Large carpet : {largecharge}");
            Console.WriteLine($"Cost : {totalwithnotax:C}");
            Console.WriteLine($"tax : {tax * totalwithnotax:C}");
            Console.WriteLine("________________________________");
            Console.WriteLine($"total estimate: {totalwithnotax + (tax * totalwithnotax):C}");

            Console.WriteLine($"This estimate Is Valid for {estimatedays}days");
        }
    }
}
