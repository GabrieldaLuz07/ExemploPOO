using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Contract : Status
    {
        int Months;
        Modality Modality;
        public bool Active;

        public override void Activate()
        {
            Active = true;
            Console.WriteLine("O contrato agora esta ativo");
        }

        public override void Inactivate()
        {
            Active = false;
            Console.WriteLine("O contrato agora esta inativo");
        }

        public Contract()
        {
        }

        public Contract(int months, Modality modality, bool status)
        {
            Months = months;
            Modality = modality;
            Active = status;
        }
    }
}
