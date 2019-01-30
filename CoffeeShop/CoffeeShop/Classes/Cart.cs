using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Classes
{
    public class Cart
    {

        public List<ISellable> ItemsInCart = new List<ISellable>();

        public void AddItemToCart(ISellable item)
        {
            ItemsInCart.Add(item);
        }
    }
}
