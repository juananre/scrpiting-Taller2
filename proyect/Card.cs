using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public enum Affinity
    {
        Common,
        Rare,
        SuperRare,
        UltraRare,
    }

    public abstract class Card
    {
       public string name;
       public int cp;      
    }
}