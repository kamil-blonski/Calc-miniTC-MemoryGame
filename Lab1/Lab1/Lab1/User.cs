using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class User
    {
        private string name { get; set; }
        private string surname { get; set; }
        private int age { get; set; }
        public User()
        {

        }
        public User(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public override string ToString()
        {
            return name + " " + surname + " " + age;
        }
    }
}
