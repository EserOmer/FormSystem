﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public class ENTForm : IEntity
    {
        public int ID { get; set; }
        public int USER_ID { get; set; }
        public bool FORM_TYPE { get; set; }
        public bool FORM_STATUS { get; set; }

    }
}
