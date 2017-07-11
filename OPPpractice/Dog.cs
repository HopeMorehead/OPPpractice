using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPpractice
{
    class Dog
    {

        //Create a Dog class
        //Your dog class should have fields for hair length, height, running speed,
        //and weight
        //Your class should have the following behaviors: run,bark,potty, cuddle


        private string hairLength;
        private int height;
        private int runningSpeed;
        private bool crap = true;
        double  weight;



        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }

        }


        public string Height
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }

        }


        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }


      //This is my default constructor
        public Dog()
        {

        }




        public Dog(string age, int height, int runningSpeed)
        {
            this.hairLength = age;
            this.height= height;
            this.runningSpeed = runningSpeed;
        }






        public double barkVolume { get; set; }







        public int run(string runningSpeed)
        {


            Console.WriteLine("My dog likes to run fast");
            RunningSpeed -= 1;



            return 2;
        }


        public string bark(string runningSpeed)
        {


            Console.WriteLine("woofwoofwoof");

            return runningSpeed;
        }




        public double Potty()//string runningSpeed)
        {

            if (crap == true)
            {
                Console.WriteLine("YOur dog just made a mess.");
                weight -= 1.0;
            }
            else
            {
                Console.WriteLine("Your dog needs to go");
                weight += 1.0;
            }
            return weight;
        }

        public string cuddle(string runningSpeed)
        {


            Console.WriteLine("My dog loves to cuddle");

            return runningSpeed;
        }














    };
}
