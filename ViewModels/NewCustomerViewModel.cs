using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThaiMovie.Models;

namespace ThaiMovie.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}