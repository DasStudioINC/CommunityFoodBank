using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityFoodBank
{
    public class FoodItem
    {
        private int itemID = 0;

        public int ItemID
        {
            get { return itemID; }
            set
            {
                if (value > 0)
                    itemID = value;
            }
        }

        private string foodName = "";

        public string FoodName
        {
            get { return foodName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    foodName = value;
            }
        }

        private Category category = Category.DRY_FOOD;

        public Category FoodCategory
        {
            get { return category; }
            set
            {
                category = value;
            }
        }


        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }

        public void Display()
        {
            Console.WriteLine(
                $"ID: {ItemID}\n" +
                $"Item: {FoodName}\n" +
                $"Category: {FoodCategory}\n" +
                $"Quantity: {Quantity}" +
                $"\n"
                );
        }
    }
}
