using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Classes
{
    public abstract class CoffeeShopItem : ISellable
    {
        public decimal Cost
        {
            get
            {
                return CalculateCost();
            }
        }
        public int Calories
        {
            get
            {
                return CalculateCalories();
            }
        }

        protected abstract int CalculateCalories();

        protected abstract decimal CalculateCost();

        public abstract string CartDisplayInfo();

    }
}
