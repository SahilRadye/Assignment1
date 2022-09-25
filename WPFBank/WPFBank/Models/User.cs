using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBank.Models
{
    public class User
    {
        public long? CardNo { get; set; }

        public string Name { get; set; }

        public int? PinNo { get; set; }

        public decimal? Balance { get; set; }
    }
}
