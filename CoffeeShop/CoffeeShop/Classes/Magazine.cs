using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Classes
{
    public class Magazine : BookStoreItem
    {
        private int IssueNumber { get; }

        public Magazine(string title, decimal cost, int issueNumber) : base(title, cost)
        {
            IssueNumber = issueNumber;
        }

        public override string CartDisplayInfo()
        {
            return $"Magazine Title: {Title}\nIssue Number: {IssueNumber}\nCost: {Cost.ToString("C")}\n";
        }
    }
}
