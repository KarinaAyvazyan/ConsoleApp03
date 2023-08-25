using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
   public class User:BaseEntity
    {
        [MaxLength(100)]    
        public  string FirstName { get;set; }
        [MaxLength(100)]
        public string LastName { get;set; }
        [MaxLength(50)]
        public string Email { get;set; }
        public string Password { get;set; }

    }
}
