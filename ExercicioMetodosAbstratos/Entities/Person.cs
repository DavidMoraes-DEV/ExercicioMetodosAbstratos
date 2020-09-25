using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioMetodosAbstratos.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double AnnualTax();

        public override string ToString()
        {
            return Name + ": $ " + AnnualTax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
