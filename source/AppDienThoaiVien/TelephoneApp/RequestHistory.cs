﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneApp
{
    public class RequestHistory
    {
        public RequestHistory(string address, int status, int typeofcar)
        {
            this.address = address;
            this.status = status;
            this.typeofcar = typeofcar;
        }

        public string address { get; set; }
        public int status { get; set; }
        public int typeofcar { get; set; }
    }
}
