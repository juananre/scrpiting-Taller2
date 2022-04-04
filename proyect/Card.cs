using System;

namespace project
{
    abstract class Card
    {
        string name;
        int cp;

        public enum Affinity
        {
            Common,
             Rare,
              SuperRare,
              UltraRare,
            
        };

    }
}