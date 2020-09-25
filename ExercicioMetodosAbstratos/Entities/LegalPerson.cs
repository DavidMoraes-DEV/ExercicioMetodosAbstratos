using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMetodosAbstratos.Entities
{
    class LegalPerson : Person
    {
        public int EmployeeNumber { get; set; }

        public LegalPerson(string name, double annualIncome, int employeeNumber) : base(name, annualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double AnnualTax()
        {
            double tax = 0.0;
            if (EmployeeNumber > 10)
            {
                tax = 0.14;
            }
            else
            {
                tax = 0.16;
            }

            return AnnualIncome * tax;
        }
    }
}
