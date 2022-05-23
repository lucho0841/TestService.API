﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Host.Models
{
    public class User
    {
        public int userId { get; set; }
        public string numIdentification { get; set; }
        public string userName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
