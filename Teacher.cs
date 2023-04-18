using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCSharp
{
    public class Teacher : Person, Talkable
    {

        private int age;

        public Teacher(int age, String name) :
                base(name)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public String talk()
        {
            return "Don\'t forget to do the assigned reading!";
        }
    }
}
