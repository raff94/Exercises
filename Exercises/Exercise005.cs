using System;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (input.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
