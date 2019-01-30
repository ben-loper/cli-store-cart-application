using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Classes
{
    public abstract class BookStoreItem : ISellable
    {
        public decimal Cost { get; }
        public string Title { get; }

        public BookStoreItem(string title, decimal cost)
        {
            Cost = cost;
            Title = title;
        }

        public abstract string CartDisplayInfo();
    }
}
