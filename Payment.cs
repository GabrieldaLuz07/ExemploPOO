using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Payment : Contract
    {
        Student Student;
        DateTime PayDay;
        Contract Contract;

        public Payment(Student student, DateTime payDay, Contract contract)
        {
            Student = student;
            PayDay = payDay;
            Contract = contract;
            Console.WriteLine("Contrato pago!");
        }
    }
}
