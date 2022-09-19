using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BankDataLibrary
{
    public class Transaction
    {
        public long Transaction_Id { get; set; }

        public string Transaction_Type { get; set; }

        public DateTime? DateTime { get; set; }

        public decimal Amount { get; set; }

        public long CardNo { get; set; }

    }
}
