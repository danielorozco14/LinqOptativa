using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaLINQ
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Declaring Lists
            var personas = new List<Persona>();
            var pets = new List<Pet>();

            //Declaring Objects
            var persona = new Persona();
            var pet = new Pet();

            //Inserting Data to the Lists
            persona.initPersonaList(personas);
            pet.initPetsList(pets);

            /* Exercise : Complete the following queries using only LINQ
             * 
             * For example: 
            * 
                * var allPetsThatAreLost = from p in pets ....
                * 
                * or 
                * 
                * var allPetsThatAreLost = pets.Where()...

            */


            // 1. Show all pets that are Lost

            var allPetsThatAreLost; 

            // 2. Show the pets that are dogs

            var allDogs; 

            // 3. Show people older than 10

            var peopleOlderThan10; 

            // 4. Show people who doesn't have a pet

            var peopleWithoutPets; 

            // 5. Show the info of the pets of the people who are older than 15

            var infoOfPets;

            // 6. Show all the people who has pets and live in San Salvador

            var peopleLivingInSS;

            // 7. Count all the people who have pets

            var peopleWithPets;

            // 8. Show the info of all the people who are less than 15 yro
            //and does not live in S.S.

            var pplLessThan15;

            // 9. Show all the Cats who are older than 3 years old

            var catsOlderThan3yro;

            // 10. Show the info of the owners of Birds

            var infoOfOwnerOfBirds;

            Console.ReadLine();
        }
    }
}
