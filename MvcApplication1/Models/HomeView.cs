using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class HomeView
    {
        [Required(ErrorMessage = "Error message here.")]
        [RegularExpression(@"^[^,<>\s@]+@([^\s,@\.\[\]]+\.)*[^\s,@\.\[\]]+\.[^\s,@\.\[\]]+$", ErrorMessage = "Invalid Email")]
        [MaxLength(255)]
        public string Email { get; set; }

        public bool AcceptRules { get; set; }
    }
}