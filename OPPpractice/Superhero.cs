using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPpractice
{
    class Superhero
    {

        //5fields

        private string costome;
        private string name;
        private int strengthLevel;
        private string power;
        private bool hasCape;


        //5Properties

        public string Costome

        {
            get { return this.costome; }
            set { this.costome = value; }

        }

        public string Name
        {
            get { return this.name; }
        }

        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public string Power
        {
            get { return this.power; }
        }

        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }


        public Superhero()
        {

            //this is my default constructor

        }




        //3Constructors



        public Superhero(string name)
        {
            this.name = name;
            this.strengthLevel = 100;
        }


        public Superhero (string costume, string name, int strengthLevel, string power, bool hasCape)
        {

            this.costome = name;

            this.name = name;

            this.strengthLevel = strengthLevel;

            this.power = power;

            this.hasCape = hasCape;
        } 
        //2 Methods
        public void BattleNemesis()
        {

            this.StrengthLevel -= 10;
            this.HasCape = false;
            this.Costome = "tattered";
        }

        public void GetHealthy(string costume, int strengthLevel)
        {
            this.Costome = costume;
        //    this.StrengthLevel = strenghLevel;
        }


        public void AllyGained()
        {
            this.StrengthLevel += 10;
            this.HasCape = false;
            Console.WriteLine("Thank you for being a friend.");
        }

       

    }
}
