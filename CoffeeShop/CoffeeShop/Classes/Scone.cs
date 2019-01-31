using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Classes
{
    public class Scone : CoffeeShopItem
    {

        public bool HasWhipcream { get; }

        public bool HasChocolate { get; }

        public Scone(bool hasWhipcream, bool hasChocolate)
        {
            HasWhipcream = hasWhipcream;
            HasChocolate = hasChocolate;
        }


        public override string CartDisplayInfo()
        {
            return $"Scone Calories:{Calories}\nWith Whipcream: {HasWhipcream}\nWith Chocolate: {HasChocolate}\nCost: {Cost.ToString("C")}\n";
        }

        protected override int CalculateCalories()
        {
            int result = 150;

            if (HasChocolate)
            {
                result += 50;
            }
            if (HasWhipcream)
            {
                result += 25;
            }

            return result;
        }

        protected override decimal CalculateCost()
        {
            decimal result = 3.50m;

            if (HasChocolate)
            {
                result += .50m;
            }
            if (HasWhipcream)
            {
                result += .25m;
            }

            return result;
        }
    }
}
