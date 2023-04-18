using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCSharp
{
    public class Cat : Pet, Talkable
    {

        private int mousesKilled;

        public Cat(int mousesKilled, String name) : base(name)
        {
            this.mousesKilled = mousesKilled;
        }

        public int getMousesKilled()
        {
            return this.mousesKilled;
        }

        public void addMouse()
        {
            this.mousesKilled++;
        }

        
        public String talk()
        {
            return "Meow";
        }

        public String toString()
        {
            return ("Cat: " + ("name="
                        + (name + (" mousesKilled=" + this.mousesKilled))));
        }
    }

}
