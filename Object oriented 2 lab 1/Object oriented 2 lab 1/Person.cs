using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_2_lab_1
{
    internal class Person
    {
        public int personId; 
        public string firstName;
        public string lastName; 
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public void DisplayPersonInfo() // persons info//
        {
            Console.WriteLine("PersonId: " + personId + " Name: " + firstName + " " + lastName + " Favorite color is " + favoriteColour);
        }

        public void ChangeFavoriteColour() // change colour//
        {
            favoriteColour = "white";
        }

        public int GetAgeInTenYears() //age after 10 years//
        {
            return age + 10;
        }

        public override string ToString() //displays all Person Object information as a list// 
        {
            return "PersonId: " + personId + " \nName: " + firstName + " " + lastName + " \nFavorite color is " + favoriteColour + " \nAge: " + age + " \nisWorking: " + isWorking; //\n displays ouput in different lines//
        }
    }
}
