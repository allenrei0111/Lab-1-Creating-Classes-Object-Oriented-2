using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_2_lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person

            {

                personId = 1,
                firstName = "Ian",
                lastName = "Brooks",
                favoriteColour = "Red",
                age = 30,
                isWorking = true

            };


            Person person2 = new Person

            {

                personId = 2,
                firstName = "Gina",
                lastName = "James",
                favoriteColour = "Green",
                age = 18,
                isWorking = false

            };


            Person person3 = new Person

            {

                personId = 3,
                firstName = "Mike",
                lastName = "Briscoe",
                favoriteColour = "Blue",
                age = 45,
                isWorking = true

            };


            Person person4 = new Person

            {

                personId = 4,
                firstName = "Mary",
                lastName = "Beals",
                favoriteColour = "Yellow",
                age = 28,
                isWorking = true

            };



            
            Console.WriteLine("PersonId: " + person2.personId + " \nName: " + person2.firstName + " " + person2.lastName + " Favorite color is " + person2.favoriteColour); // displays person 2 info and fav colour//
            

            Console.WriteLine(person3.ToString()); //displays person 3 info in different lines//


            person1.ChangeFavoriteColour();
            Console.WriteLine( person1.ToString()); // person 1 change fav color


            Console.WriteLine("Mary Beal's age after 10 years: " + person4.GetAgeInTenYears());//adding 10 years to person 4//
        }
    }
}
