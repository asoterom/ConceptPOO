using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentage;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Commission Percentage ........: {$"{CommissionPercentage:P2}",18} " +
                $"\n\t Sales ........: {$"{Sales:C2}",18} " +
                $"\n\t Value to pay ........: {$"{GetValueToPay():C2}",18} ";
        }
    }
}
