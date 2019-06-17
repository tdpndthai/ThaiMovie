using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThaiMovie.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name ="Loại Thành Viên")]
        public byte MembershipTypeID { get; set; }

        [Display(Name ="Ngày Sinh")]
        public DateTime? Date { get; set; } //kiểu nullable cho phép gán giá trị null
    }
}