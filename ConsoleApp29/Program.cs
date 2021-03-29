using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Animal
    {
       public void animalSound()
        {
            Console.WriteLine("animal sound is this");
        }
    }
    class pig : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("animal sound it would be");
        }

    }
    class dog : Animal
    {
      public void animalSound()
        {
            Console.WriteLine("animal sound it can be");
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            pig mypig = new pig();
            dog mydog = new dog();

            myAnimal.animalSound();
            mypig.animalSound();
            mydog.animalSound();
            Console.ReadLine();
        }
    }
}
