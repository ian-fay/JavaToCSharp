using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCSharp
{
    public abstract class Pet
    {

        protected String name;

        public Pet(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }
    }
}
