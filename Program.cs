using ExemploPOO;
using System;

namespace ExemploPOO
{
    class Program
    {
        static void Main()
        {
            Modality modality = new Modality("academia", 120.00);
            Student student = new Student("Gabriel", 21, 0, "10545056632", "49988206767", modality);
            IPerson personal = new Personal("Diego", 35, 0, "11243057932", 123643);

            student.Introduce();
            personal.Introduce();

            Contract contract = new Contract(12, modality, false);
            contract.Activate();

            Payment payment = new Payment(student, DateTime.Now, contract);
            payment.PaymentOK(contract);
            


        }
    }
}