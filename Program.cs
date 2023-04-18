using System;
using System.Collections.Generic;

namespace JavaToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Talkable> zoo = new List<Talkable>();

            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));

            AddAnimal.addAnimal(zoo);

            foreach (Talkable thing in zoo)
            {
                printOut(thing);
            }
            
        }

      public static void printOut(Talkable p)
       {
            Console.WriteLine(p.getName() + " says=" + p.talk());
            //FileInput.writeFile(p.getName() + " | " + p.talk());
       }
    }
}
