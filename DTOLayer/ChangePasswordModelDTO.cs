﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class ChangePasswordModelDTO
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string CheckNewPassword { get; set; }
    }
}
