using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_LINQ
{
    internal sealed class Contact
    {
        public string Name { get; set; }

        public string Number { get; set; }

        public string Company { get; set; }

        public Contact(string name, string number, string company) 
        {
            this.Name = name;
            this.Number = number;
            this.Company = company;
        }

        public override string ToString()
        {
            return new string($"{Name} {Number} {Company}");
        }
    }
}
