using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserDTO
    {
        //Return these properties when a user logs in or registers
        public string Username { get; set; }
        public string Token { get; set; }
    }
}