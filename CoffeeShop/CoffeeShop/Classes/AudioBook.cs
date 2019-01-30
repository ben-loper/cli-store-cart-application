using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Classes
{
    public class AudioBook : BookStoreItem
    {
        public int Length { get; }
        public string Narrator { get; }
        public string Author { get; }

        public AudioBook(string title, decimal cost, int length, string author, string narrator) : base(title, cost)
        {
            Length = length;
            Author = author;
            Narrator = narrator;
        }

        public override string CartDisplayInfo()
        {
            return $"Title: {Title}\nAuthor: {Author}\nNarrator: {Narrator}\nLength (in minutes): {Length}\nCost: {Cost}\n";
        }
    }
}
