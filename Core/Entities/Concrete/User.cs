﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
   public class User: IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
    }
}
