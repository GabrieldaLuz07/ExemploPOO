using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Payment : Contract
    {
        private readonly Student _student;
        private readonly Contract _contract;
        private readonly DateTime _payDay;

        public Payment(Student student, DateTime payDay, Contract contract)
        {
            // Injeção de Dependência
            _student = student ?? throw new ArgumentNullException(nameof(student));
            // Injeção de Dependência
            _contract = contract ?? throw new ArgumentNullException(nameof(contract));
            _payDay = payDay;
        }

        public void ProcessPayment()
        {
            // Extração de Método
            if (!IsContractValid())
            {
                Console.WriteLine("O contrato não é válido para pagamento.");
                return;
            }

            Console.WriteLine($"Pagamento processado para o estudante {_student.GetName()} na data {_payDay.ToShortDateString()}.");
        }

        private bool IsContractValid()
        {
            // Extração de Método
            return _contract.Active;
        }
    }
}
