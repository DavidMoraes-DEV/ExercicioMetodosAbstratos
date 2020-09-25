using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMetodosAbstratos.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenses { get; set; }

        public PhysicalPerson(string name, double annualIncome,double healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double AnnualTax()
        {
            double tax = 0.0;
            if(AnnualIncome < 20000.0)
            {
                tax = 0.15;
            }
            else
            {
                tax = 0.25;
            }

            return (AnnualIncome * tax) - (HealthExpenses * 0.5);
        }
    }
}
