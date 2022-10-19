using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDemo.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        public string BillingAddressee { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingAddressCity { get; set; }
        public string BillingAddressState { get; set; }
        public string BillingAddressPostalCode { get; set; }

        public decimal OrderTotal { get; set; }


    }
}
