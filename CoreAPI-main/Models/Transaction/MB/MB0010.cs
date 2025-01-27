﻿

namespace WebApi.Models.Transaction.MB
{
    public class MB0010 : TransactionRequest
    {
        [CoreRequired]
        public string CREDITACC { get; set; }
        [CoreRequired]
        public string DEBITACC { get; set; }
        [CoreRequired]
        public double? AMT { get; set; }
        [CoreRequired]
        public double? DEBITFEE { get; set; }
        [CoreRequired]
        public double? CREDITFEE { get; set; }
        [CoreRequired]
        public string FEEACC { get; set; }
        [CoreRequired]
        public string ID { get; set; }
    }
}
