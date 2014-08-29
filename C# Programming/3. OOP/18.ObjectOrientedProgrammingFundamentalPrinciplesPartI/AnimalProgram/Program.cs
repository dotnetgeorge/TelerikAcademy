/*
 * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
 * Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
 * Kittens and tomcats are cats. All animals are described by age, name and sex. 
 * Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
 * Create arrays of different kinds of animals and calculate
 * the average age of each kind of animal using a static method (you may use LINQ).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalProgram.Data;

namespace AnimalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cat> cats = new List<Cat> 
            { 
                new Cat("Joro",2,'m'),
                new Cat("Maci", 1, 'f'),
                new Cat("Pisi", 3, 'm')
            };
            Console.WriteLine(cats[0].Sound());

            List<Dog> dogs = new List<Dog> 
            {
                new Dog("Joro",2,'m'),
                new Dog("Maci", 1, 'f'),
                new Dog("Pisi", 3, 'm')
            };
            Console.WriteLine(dogs[0].Sound());

            List<Frog> frogs = new List<Frog> 
            {
                new Frog("Joro",2,'m'),
                new Frog("Maci", 1, 'f'),
                new Frog("Pisi", 3, 'm')
            };
            Console.WriteLine(frogs[0].Sound());

            List<Kitten> kitties = new List<Kitten> 
            {
                new Kitten("Joro",2),
                new Kitten("Maci", 1),
                new Kitten("Pisi", 3)
            };
            Console.WriteLine(kitties[0].Sound());

            List<Tomcat> tomcats = new List<Tomcat> 
            {
                new Tomcat("Joro",2),
                new Tomcat("Maci", 1),
                new Tomcat("Pisi", 3)
            };
            Console.WriteLine(tomcats[0].Sound());

            Console.WriteLine("Average ages:");
            Console.WriteLine("Cats: " + cats.Average(x => x.Age));
            Console.WriteLine("Dogs: " + dogs.Average(x => x.Age));
            Console.WriteLine("Frogs: " + frogs.Average(x => x.Age));
            Console.WriteLine("Kitties: " + kitties.Average(x => x.Age));
            Console.WriteLine("Tomcats: " + tomcats.Average(x => x.Age));

        }
    }
}
