﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sep6.Models
{
    public class Member
    {
        public int MemberId { get; set; } 

        public string MemberName { get; set; }

        public DateTime AccOpenDate { get; set; }
    }
}