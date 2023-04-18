using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCSharp
{
    class AddAnimal
    {

        public static List<Talkable> addAnimal(List<Talkable> zoo) {

            // Type your username and press enter
            Console.WriteLine("What type of animal do you want to create? (Teacher, Cat, Dog):");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string animalType = Console.ReadLine();

            if (animalType == "Teacher")
            {
                Console.WriteLine("Enter the Teachers Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Teachers Name:");
                int age = Convert.ToInt32(Console.ReadLine());

                zoo.Add(new Teacher(age, name));

            }
            else if (animalType == "Cat")
            {

                Console.WriteLine("Enter the Cats Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Cats Number of Mice Killed:");
                int miceKilled = Convert.ToInt32(Console.ReadLine());

                zoo.Add(new Cat(miceKilled, name));

            }
            else if (animalType == "Dog")
            {

                Console.WriteLine("Enter the Dogs Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Is the Dog Friendly(True or False):");
                bool isFriendly = Convert.ToBoolean(Console.ReadLine());

                zoo.Add(new Dog(isFriendly, name));

            }

            return zoo;

        }

    }
}
