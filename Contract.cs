using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Contract : Status
    {
        private int Months;
        private Modality Modality;
        public bool Active { get; private set; }

        public Contract(int months, Modality modality, bool status)
        {
            Months = months;
            // Injeção de Dependência
            Modality = modality ?? throw new ArgumentNullException(nameof(modality));
            Active = status;
        }

        public override void Activate()
        {
            // Extração de Método
            SetActiveStatus(true);
        }

        public override void Inactivate()
        {
            // Extração de Método
            SetActiveStatus(false);
        }

        private void SetActiveStatus(bool status)
        {
            Active = status;
            Console.WriteLine($"O contrato agora está {(status ? "ativo" : "inativo")}");
        }
    }
}
