﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier7Delegue
{
    internal class User
    {
        string username;
        string password;

        public User(string username, string password) 
        {
            this.username = username;
            this.password = password;
        }

        public string Username 
        { 
            get { return username; } 
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
