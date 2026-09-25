using System.Runtime.InteropServices;

namespace CommunityFoodBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== COMMUNITY FOOD BANK INVENTORY ===\n");

            FoodItem item1 = new FoodItem
            {
                ItemID = 1,
                FoodName = "Canned Beans",
                FoodCategory = Category.CANNED_FOOD,
                Quantity = 24
            };

            FoodItem item2 = new FoodItem
            {
                ItemID = 2,
                FoodName = "Rice",
                FoodCategory = Category.DRY_FOOD,
                Quantity = 15
            };

            FoodItem item3 = new FoodItem
            {
                ItemID = 3,
                FoodName = "Ice Cream",
                FoodCategory = Category.COLD_FOOD,
                Quantity = 4
            };

            FoodItem item4 = new FoodItem
            {
                ItemID = 4,
                FoodName = "Apples",
                FoodCategory = Category.COLD_FOOD,
                Quantity = 3
            };

            FoodItem item5 = new FoodItem
            {
                ItemID = 5,
                FoodName = "Pizza",
                FoodCategory = Category.HOT_FOOD,
                Quantity = 2
            };

            List<FoodItem> items = new List<FoodItem>
            {
                item1,
                item2,
                item3,
                item4,
                item5
            };


            foreach(FoodItem item in items)
            {
                item.Display();
            }

            // Chnaged for more detail to show total number of items
            Console.WriteLine($"Number of inventory units: {items.Sum(e => e.Quantity)}");

            // Get lowest count of item
            Console.WriteLine($"Lowest Item Quant Name: {items.OrderByDescending(e => e.Quantity).First().FoodName}");
        }

    }
}
