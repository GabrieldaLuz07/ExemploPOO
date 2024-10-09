using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Modality
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Modality(string name, double price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("O nome da modalidade não pode ser vazio.", nameof(name));

            if (price <= 0)
                throw new ArgumentException("O preço deve ser maior que zero.", nameof(price));

            Name = name;
            Price = price;
        }
    }
}
