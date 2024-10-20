using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagementAPI.Domain.Entites
{
    internal class User
    {
        public guid Id{get;set;}
        [Requied] 
        public string FirstName{get;set;}
        [Required]
        public string LastName{get;set}
        [Required]
        public int PhoneNo{get;set;}
        public string temp{get;set;}
        public string temp{get;set;}
        public string temp{get;set;}
        public string temp{get;set;}
    }
}
