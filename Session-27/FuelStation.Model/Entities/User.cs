﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
