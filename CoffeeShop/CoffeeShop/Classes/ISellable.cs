using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Classes
{
    public interface ISellable
    {
        decimal Cost { get; }
        string CartDisplayInfo();
    }
}
