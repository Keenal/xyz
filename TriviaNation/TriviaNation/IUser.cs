﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNation
{
    public interface IUser
    {
        string UserName
        {
            get; set;
        }

        string Email
        {
            get; set;
        }

        string Password
        {
            get; set;
        }
        string Score
        {
            get; set;
        }
    }
}