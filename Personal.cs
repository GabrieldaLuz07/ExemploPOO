using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Personal : IPerson
    {
        public string Name { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
        public int Cref;

        public Personal(string name, int age, int gender, string cpf, int cref)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Cpf = cpf;
            Cref = cref;
        }

        public string GetName() => Name;

        public void Introduce() 
        { 
            Console.WriteLine($"Sou o personal {Name}, prazer.");
        }
    }
}
