using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    namespace TrashPickup.Models
    {
        public class Customer
        {
            string Email { get; set; }
            string Street { get; set; }
            string Address { get; set; }
            string State { get; set; }
            string Zip { get; set; }
            sbyte pickupDay { get; set; }
            DateTime suspendStart { get; set; }
            DateTime suspendEnd { get; set; }
            DateTime OneTimePickup { get; set; }
        }
    }
}