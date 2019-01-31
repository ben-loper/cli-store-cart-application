using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Classes
{
    public class Coffee : CoffeeShopItem
    {
        private int Ounces
        {
            get
            {
                int result = 12;

                if(Size.ToLower() == "medium")
                {
                    result = 18;

                } else if(Size.ToLower() == "large")
                {
                    result = 24;
                }
                return result;
            }
        }

        private int TotalCalories
        {
            get
            {
                return CalculateCalories();
            }
        }

        public string Size { get; }

        public Coffee(string size)
        {
            Size = size;
        }

        protected override int CalculateCalories()
        {
            return Ounces / 6;
        }

        protected override decimal CalculateCost()
        {
            decimal result = 1.5m;

            if(Size.ToLower() == "medium")
            {
                result = 2.5m;
            } else if(Size.ToLower() == "large")
            {
                result = 4.0m;
            }

            return result;
        }

        public override string CartDisplayInfo()
        {
            return $"Coffee Size: {Size}\nTotal Calories: {TotalCalories}\nCost: {Cost.ToString("C")}\n";
        }

    }
}
