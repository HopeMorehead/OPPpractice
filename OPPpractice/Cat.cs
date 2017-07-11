using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPpractice
{
    class Cat
    { 
        //Inside of our class, we create  the blueprint for our object.
        //Theyy should always save as Pascal cat ctrl shift cat
        //In OOP, there are two types of States:
        //Fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        

        //properties a short of mix between a field and a method that allow controlled access
        public string Name
        {

            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
        }
        //we also have behaviore
        //methods  repeatable/reusable sections of code-action
        //constructors- specialized methods that are used when instantiating an object
        public Cat()
        {
        // this is an example of a default constructor.A default constructor takes
       // no arguements/parameter
        }
       // allow us to he state of an control the state of an object upon creation.
      //  always share the name of the class
      //can have as many constructors as you need as long as they each have a unique signature.
      //by signature, I mean the parameters in the parentheses after the constructor name.
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry?" + isHungry);
        }

    }
}
