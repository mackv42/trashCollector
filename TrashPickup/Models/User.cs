using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class User
    {
        string Email { get; set; }
        string Street { get; set; }
        string Address { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        sbyte pickupDay { get; set; }
        DateTime suspendStart;
        DateTime suspendEnd;
        DateTime OneTimePickup;
    }
}