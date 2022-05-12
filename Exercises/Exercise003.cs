using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Exercise003
    {
        private readonly KeyValuePair<string, int>[] iceCreamFlavoursCodes = new KeyValuePair<string, int>[]
       {
            new KeyValuePair<string, int>("Pistachio", 0 ),
            new KeyValuePair<string, int>("Raspberry Ripple", 1 ),
            new KeyValuePair<string, int>("Vanilla", 2 ),
            new KeyValuePair<string, int>("Mint Chocolate Chip", 3 ),
            new KeyValuePair<string, int>("Chocolate", 4 ),
            new KeyValuePair<string, int>("Mango Sorbet", 5 )
       };

        public string[] IceCreamFlavours => iceCreamFlavoursCodes
            .Select(item => item.Key)
            .ToArray();

        public int IceCreamCode(string iceCreamFlavour) => iceCreamFlavoursCodes
            .FirstOrDefault(item => item.Key == iceCreamFlavour)
            .Value;
    }
}
