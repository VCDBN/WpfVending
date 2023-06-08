using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVending.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransActionDateTime { get; set; }
        public Product TransactionProduct { get; set; }
        public int TransactionQty { get; set; }
        public double TransactionTotal { get; set; }

        public Transaction(int transactionId, DateTime transActionDateTime, Product transactionProduct, int transactionQty, double transActionTotal)
        {
            TransactionId = transactionId;
            TransActionDateTime = transActionDateTime;
            TransactionProduct = transactionProduct;
            TransactionQty = transactionQty;
            TransactionTotal = transActionTotal;
        }
    }
}
