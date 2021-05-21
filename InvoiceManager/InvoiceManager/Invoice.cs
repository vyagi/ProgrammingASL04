using System;

namespace InvoiceManager
{
    public class Invoice
    {
        public string Name;

        public DateTime Date;

        public decimal Amount;

        public Invoice(string line)
        {
            var split = line.Split('\t');
            Name = split[0];
            Date = Convert.ToDateTime(split[1]);
            Amount = Convert.ToDecimal(split[2]);
        }
    }
}