using Exercises.Models;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Exercise002
    {
        public static void IsFromManchester(List<User> manchester)
        {
            //create list
            List<User> manchester = new List<User>();

            manchester.AddRange("Peter", 
                                "Smith", 
                                "Manchester", 
                                23);

            //check if element is present
            if (manchester.Contains("Manchester"))
            {
                return true;
            }

        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }
    }
}
