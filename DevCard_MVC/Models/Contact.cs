using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="فیلد جاری اجباری است")]
        [MaxLength(100,ErrorMessage ="حداکثر حروف از 100 تا بیشتر نشود")]
        [MinLength(3,ErrorMessage ="حداقل تعداد حروف از 3 باید بیشتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "فیلد جاری اجباری است")]
        [EmailAddress]
        public string Email { get; set; }

        public string Message { get; set; }
        public int Service { get; set; }

        public SelectList Services { get; set; }
    }
}
