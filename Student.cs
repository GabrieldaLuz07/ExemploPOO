using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Student : IPerson
    {
        public string Name { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
        public string Telefone;
        public Modality modality;

        public Student(string name, int age, int gender, string cpf, string telefone, Modality modality)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Cpf = cpf;
            Telefone = telefone;
            this.modality = modality;
        }

        public string GetName() { return Name; }

        public void Introduce() { Console.WriteLine($"Meu nome é {Name}."); }
    }
}
