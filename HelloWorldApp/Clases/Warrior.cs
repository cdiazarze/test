using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Clases
{
    public class Warrior
    {
        // Atributos
        private string name;
        private string faction;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        /* Propiedades: Acceso a los atributos de la clase. La ventaja de estas es que permite poner
         * condiciones para leer o escribir sobre un atributo. Por ejemplo, uno puede poner la condición
         * de que los puntos de vida iniciales no pueden ser menor a 0.
        */

        public string Name { get => name; set => name = value; }
        public string Faction { get => faction; set => faction = value; }

        public int AbilityPoints{
            get
            {
                return abilityPoints;
            }
            set 
            {
                if(value >= 0 && value <= 100)
                {
                    abilityPoints = value;
                }
                else
                {
                    abilityPoints = 0;
                    Console.WriteLine("abilityPoints must be positive. Default to 0.");
                }
            }
        }

        public int HealthPoints { get => healthPoints; set => healthPoints = value; }
        public int Level { get => level; set => level = value; }


        // Constructor
        public Warrior(string name, string faction)
        {
            this.abilityPoints = 10;
            this.healthPoints = 50;
            this.level = 1;
            this.faction = faction;
            this.name = name;
        }


        // Comportamientos - Funciones
        public void Strike()
        {
            Console.WriteLine("Warrior attack!");
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
