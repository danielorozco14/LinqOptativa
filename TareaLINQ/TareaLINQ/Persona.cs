using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaLINQ
{
    class Persona
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public bool hasAPet { get; set; }

        public Persona() { }
        public Persona(int Id, string name, int age, string state, string city, bool hasAPet)
        {
            this.Id = Id;
            this.name = name;
            this.age = age;
            this.state = state;
            this.city = city;
            this.hasAPet = hasAPet;
        }

        public void initPersonaList(List<Persona> personas)
        {
            Persona persona1 = new Persona(1, "Juan", 23,"San Miguel", "Chinameca", true);
            Persona persona2 = new Persona(2, "Maria", 13, "La Libertad", "Ciudad Merliot", true);
            Persona persona3 = new Persona(3, "Pedro", 15, "Cuscatlan", "Cojutepeque", false);
            Persona persona4 = new Persona(4, "Pedro", 15, "San Salvador", "Ilopango", false);

            Persona persona5 = new Persona(5, "Lourdes", 10, "La Paz", "Zacatecoluca", true);
            Persona persona6 = new Persona(6, "Alexis", 9, "La Libertad", "Santa Tecla", false);
            Persona persona7 = new Persona(7, "Alejandro", 25, "Cuscatlan", "Suchitoto", false);
            Persona persona8 = new Persona(8, "Mirna", 15, "San Salvador", "Santiago Texacuango", false);

            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(persona3);
            personas.Add(persona4);

            personas.Add(persona5);
            personas.Add(persona6);
            personas.Add(persona7);
            personas.Add(persona8);
        }
    }
}
