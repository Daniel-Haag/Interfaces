using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacaoContratos.Entidades
{
    public class Contract
    {
        public Contract(int Number, DateTime Date, decimal Value, int NumberOfInstallments)
        {
            this.Number = Number;
            this.Date = Date;
            this.Value = Value;
            this.NumberOfInstallments = NumberOfInstallments;
        }

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public int NumberOfInstallments { get; set; }
    }
}
