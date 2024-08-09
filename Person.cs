using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public interface IPerson
    {
        string Name { get; set; }
        int Gender { get; set; }
        int Age { get; set; }
        string Cpf { get; set; }

        string GetName();
        void Introduce();

    }
}
