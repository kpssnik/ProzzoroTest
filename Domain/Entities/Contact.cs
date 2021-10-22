using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProzzoroTest.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Experience { get; set; }
        public string Email { get; set; }     
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        [DefaultValue(false)]
        public bool IsValid { get; set; }
    }
}
