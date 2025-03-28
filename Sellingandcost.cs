// wap to input cp & cp and Check profit or loss also find profit or loss amount

using System;

public class SellingAndCost
{
    public void CalculateProfitOrLoss()
    {
        Console.Write("Enter the cost price (CP): ");
        double costPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the selling price (SP): ");
        double sellingPrice = Convert.ToDouble(Console.ReadLine());

        if (sellingPrice > costPrice)
        {
            double profit = sellingPrice - costPrice;
            Console.WriteLine("Profit Amount:" + profit);
        }
        else if (sellingPrice < costPrice)
        {
            double loss = costPrice - sellingPrice;
            Console.WriteLine("Loss Amount: " +loss);
        }
        else
        {
            Console.WriteLine("No Profit No Loss");
        }
    }

    public static void Main()
    {
        SellingAndCost sc = new SellingAndCost();
        sc.CalculateProfitOrLoss();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}