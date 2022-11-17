using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class FullName
    {
        [MaxLength(25, ErrorMessage = "Maximum 25 caractére")]
        [MinLength(3, ErrorMessage = "Minimum 3 carecteres")]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}
