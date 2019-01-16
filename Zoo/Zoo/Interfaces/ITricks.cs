using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface ITricks
    {
        bool FunTricks { get; set; }

        string Perform();
    }
}
