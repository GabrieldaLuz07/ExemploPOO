using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Student : IPerson
    {
        public string Name { get; private set; }
        public int Gender { get; private set; }
        public int Age { get; private set; }
        public string Cpf { get; private set; }
        public string Telephone { get; private set; }
        public Modality Modality { get; private set; }

        public Student(string name, int age, int gender, string cpf, string telephone, Modality modality)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("O nome não pode ser vazio ou nulo.", nameof(name));

            if (age <= 0)
                throw new ArgumentException("A idade deve ser maior que zero.", nameof(age));

            if (string.IsNullOrWhiteSpace(cpf))
                throw new ArgumentException("O CPF não pode ser vazio ou nulo.", nameof(cpf));

            Name = name;
            Age = age;
            Gender = gender;
            Cpf = cpf;
            // Injeção de Dependência
            Telephone = telephone ?? throw new ArgumentNullException(nameof(telephone));
            // Injeção de Dependência
            Modality = modality ?? throw new ArgumentNullException(nameof(modality));
        }

        public string GetName() => Name;

        public void Introduce()
        {
            // Extração de Método
            Console.WriteLine($"Meu nome é {Name} e estou inscrito na modalidade {Modality.Name}.");
        }
    }
}
