﻿using Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
