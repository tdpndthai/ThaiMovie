using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThaiMovie.Models;

namespace ThaiMovie.ViewModels
{
    public class InfoCustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}