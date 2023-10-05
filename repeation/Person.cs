using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeation
{
    class Person
    {
        public string name;
        public int age;
        private string secret;

        public string Secret 
            {
            get { return secret; }
            set { secret = value; } 
            }
    public Person(string name, int age, string secret)
        {
            this.name = name;
            this.age = age;
            this.secret = secret;
        }

    }
}
