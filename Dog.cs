using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCSharp
{
    public class Dog : Pet, Talkable
    {

        private bool friendly;

        public Dog(bool friendly, String name) :
                base(name)
        {
            this.friendly = friendly;
        }

        public bool isFriendly()
        {
            return this.friendly;
        }

 
        public String talk()
        {
            return "Bark";
        }

     
        public String toString()
        {
            return ("Dog: " + ("name="
                        + (name + (" friendly=" + this.friendly))));
        }
    }
}
