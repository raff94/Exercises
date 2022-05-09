using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {

        public string CapitalizeWord(this string word)
        {
            if (string.IsNullOrEmpty(word))
                return string.Empty;
            
            // convert to char array of the string
            char[] letters = word.ToCharArray();
            
            // upper case the first char
            letters[0] = char.ToUpper(letters[0]);
            
            // return the array made of the new char array
            return new string(letters);

        }

        public string GenerateInitials(string name)
        {
            // Excludes empty spaces returned by the Split method

            string[] NameSplit = name.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            string initials = "";

            foreach (string item in NameSplit)
            {
                initials += item.Substring(0, 1).ToUpper();
            }

            return initials;

        }

        public decimal AddVat(decimal price, decimal vatRate, decimal total)
        {

            Console.WriteLine("Please enter the price without VAT");
            price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the VAT rate");
            decimal input;
            if(Decimal.TryParse(Console.ReadLine(), out input))
            {
                vatRate = input / 100;
            }
            else
            {
                vatRate = 0.20M;
            }
            total = price * vatRate;
            Console.WriteLine("Total price = {0}", total);

        }

        public string Reverse(string sentence)
        {
            string Str, rev;
            Str = "Programming";
            rev = "";
            Console.WriteLine("Value of given String is: {0}", Str);
            // find string length
            int a;
            a = Str.Length - 1;
            while (a >= 0)
            {
                rev = rev + Str[a];
                a--;
            }
            Console.WriteLine("Reversed string is: {0}", rev);
            Console.ReadLine();
            
        }

        public int CountLinuxUsersZero(List<User> users)
        {

            List<User> linuxusers = new List<User>();
            linuxusers.AddRange("Heather", "Windows 10", "Windows");
            linuxusers.AddRange("Paul", "Windows 95", "Windows");

            string myString = "Linux";

            var matchingvalues = User.Where(stringToCheck => stringToCheck.Contains(myString));

        }

        public int CountLinuxUsersCorrectCount(List<User> users)
        {
            List<User> linuxusers = new List<User>();

            linuxusers.AddRange("Heather",
                                "Windows 10",
                                "Windows");
            linuxusers.AddRange("Paul","Windows 95", "Windows");
            linuxusers.AddRange("Shelia", "CentOS 7", "Linux");
            linuxusers.AddRange("Pedro", "Ubuntu 18.04", "Linux");

            string myString = "Linux";

            var matchingvalues = User.Where(stringToCheck => stringToCheck.Contains(myString));

        }
    }
}
