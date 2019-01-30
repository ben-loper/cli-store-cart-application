using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Classes
{
    public class Book : BookStoreItem
    {
        public int Pages { get; private set; }
        public string Author { get; private set; }
        public string DatePublished { get; private set; }


        public Book(int pages, string author, string datePublished, decimal cost, string title) : base(title, cost)
        {
            Pages = pages;
            Author = author;
            DatePublished = datePublished;
        }

        public override string CartDisplayInfo()
        {
            return $"Title: {Title}\nAurthor: {Author}\nDate Published: {DatePublished}\nCost: {Cost.ToString("C")}\n";
        }
    }
}
