using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RazorAjax.Models
{
    public class RazorAjaxViewModels
    {
        [Required]
        [Display(Name = "Text")]
        public string Text
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "UserName")]
        public string Username
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password
        {
            get;
            set;
        }
    }
}