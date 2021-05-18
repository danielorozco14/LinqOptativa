using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaLINQ
{
    class Pet
    {
        public int ownerId { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string specie { get; set; }
        public bool isLost { get; set; }

        public Pet() { }
        public Pet(int ownerId, string name,int age, string specie, bool isLost)
        {
            this.name = name;
            this.age = age;
            this.ownerId = ownerId;
            this.specie = specie;
            this.isLost = isLost;
        }

        public Pet(string name,int age, string specie, bool isLost)
        {
            this.ownerId = 0;
            this.name = name;
            this.age = age;
            this.specie = specie;
            this.isLost = isLost;
        }

        public void initPetsList(List<Pet> pets)
        {
            Pet pet1 = new Pet(1, "Mishi", 6, "Cat", true);
            Pet pet2 = new Pet(8, "Ranger", 5, "Dog", false);
            Pet pet3 = new Pet(2, "Spyke", 4, "Bird", false);
            Pet pet4 = new Pet(3, "Galatea", 5, "Cat", true);
            Pet pet5 = new Pet(4, "Sally", 10, "Dog", false);
            Pet pet6 = new Pet(4, "Teo", 1, "Cat", true);
            Pet pet7 = new Pet("Eri", 5, "Dog", false);
            Pet pet8 = new Pet("Dona", 1, "Cat", true);
            Pet pet9 = new Pet(1, "Loropechika", 4, "Bird", true);
            Pet pet10 = new Pet(5, "Nemo", 1, "Fish", false);
            Pet pet11 = new Pet(4, "Rio", 6, "Bird", true);
            Pet pet12 = new Pet(5, "Tiburoncin", 2, "Fish", false);

            pets.Add(pet1);
            pets.Add(pet2);
            pets.Add(pet3);
            pets.Add(pet4);
            pets.Add(pet5);
            pets.Add(pet6);
            pets.Add(pet7);
            pets.Add(pet8);
            pets.Add(pet9);
            pets.Add(pet10);
            pets.Add(pet11);
            pets.Add(pet12);

        }


    }
}
