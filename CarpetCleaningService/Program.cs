using System;

class CarpetCleaningService
{
    static void Main()
    {
        const double priceForSmallCarpet = 25;
        const double priceForLargeCarpet = 35;
        const double taxesRate = 0.06;

        Console.Write("Please enter the number of small carpets: ");

        int numberOfSmallCarpets = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of large carpets: ");
        int numberOfLargeCarpets = int.Parse(Console.ReadLine());

        double costOfSmallCarpets = numberOfSmallCarpets * priceForSmallCarpet;
        double costOfLargeCarpets = numberOfLargeCarpets * priceForLargeCarpet;
        double totalCost = costOfSmallCarpets + costOfLargeCarpets;
        double tax = totalCost * taxesRate;
        double totalEstimate = totalCost + tax;

        Console.WriteLine("\nEstimate for carpet cleaning service");
        // user input for number of carpets
        Console.WriteLine($"Number of small carpets: {numberOfSmallCarpets}");
        Console.WriteLine($"Number of large carpets: {numberOfLargeCarpets}");
        //price for small and large carpets
        Console.WriteLine($"Price per small room: {priceForSmallCarpet}");
        Console.WriteLine($"Price per large room: {priceForLargeCarpet}");
        //cost for small and large carpets and total
        Console.WriteLine($"Cost per large room: {costOfSmallCarpets}");
        Console.WriteLine($"Cost per large room: {costOfLargeCarpets}");
        Console.WriteLine($"Cost: {totalCost}");
        // tax value
        Console.WriteLine($"Tax: {tax}");
        Console.WriteLine("===============================");

        Console.WriteLine($"Total estimate: {totalEstimate}");
        Console.WriteLine("This estimate is valid for 30 days");
    }
}
