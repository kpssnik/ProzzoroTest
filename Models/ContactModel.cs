using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProzzoroTest.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage ="Please enter your name")]
        [RegularExpression(@"^([А-Я][а-я]{0,})\s([А-Я][а-я]{0,})$", ErrorMessage = "Incorrect name. Pattern: FirstName LastName")]
        [MaxLength(40, ErrorMessage = "Incorrect name. So long, 40 symbols max")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Range(0, 99, ErrorMessage = "Incorrect age. Valid 0-99")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Please enter your working experience")]
        [Range(0, 99, ErrorMessage ="Incorrect experience. Valid 0-99")]
        public int Experience { get; set; }

        [Required(ErrorMessage ="Please enter your email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Incorrect email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression(@"^\+?3?8?(0\d{2}\d{3}\d{2}\d{2})$", ErrorMessage = "Incorrect phone number. Valid: +380xxxxxxxxx or 380xxxxxxxxx")]
        [MaxLength(13, ErrorMessage = "Incorrect phone. Too long")]
        public string PhoneNumber { get; set; }

        [MaxLength(1000, ErrorMessage ="Incorrect message. Too long. 1000 symbols max")]
        public string Message { get; set; }
    }
}
