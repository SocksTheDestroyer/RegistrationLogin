﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RegistrationLogin.Data.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string Password { get; set; }
    }
}
