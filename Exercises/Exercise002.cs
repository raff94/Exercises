using System;


namespace Exercises
{
    public class Exercise002
    {

        public bool IsFromManchester(Person person)
        {
            if (person.City == "Manchester")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person.Age < ageLimit)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
            public int Age { get; set; }

            public Person(string firstName, string lastName, string city, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                City = city;
                Age = age;
            }
        }
    }
}

