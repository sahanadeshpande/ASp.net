﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginWithASPNETMVC.Models
{
    public class Account

    {   [Display(Name="Username")]
            public string Username
        {
            get;
            set;
        }
        [Display(Name = "Password")]
        public string PassWord

        {
            get;
            set;

        }
    }
}