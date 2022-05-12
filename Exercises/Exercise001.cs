using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);

        }

        public string GenerateInitials(string firstName, string lastName)
        {

            return String.Format("{0}.{1}", firstName[0], lastName[0]);

        }

        public double AddVat(double originalPrice, double vatRate)
        {
            return originalPrice + vatRate;
        }

        public string Reverse(string sentence)
        {
            char[] chars = sentence.ToCharArray();
            Array.Reverse(chars);
            string reversedText = new string(chars);
            return reversedText;
        }

        public int CountLinuxUsers(List<User> users)
        {
            int count = users.Where(i => i != null && i.Type.Equals("Linux")).Count();

            return count;
        }
    }
}
