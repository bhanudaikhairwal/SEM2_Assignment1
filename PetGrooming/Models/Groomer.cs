﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGrooming.Models
{
    public class Groomer
    {
        /* 
            A groomer is someone who is employed to groom pets
            Some things that describe a groomer
                - First Name
                - Last Name
                - Date of Birth
                - Phone Number
                - Hourly Rate

            A booking must reference to a groomer
        */

        [Key]
        public int GroomerID { get; set; }
        public string G_fname { get; set; }
        public string G_lname { get; set; }
        public int G_Rate { get; set; } //Described the cents per hour(i.e. $20/hr = 2000cents/hr)
        public string G_Experience { get; set; }
        
    }

}