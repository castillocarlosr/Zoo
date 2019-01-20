using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Classes;

namespace Zoo.Interfaces
{
    public interface ITricks
    {
        bool FunTricks { get; set; }

        string Perform();
    }
}
