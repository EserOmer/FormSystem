﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSystem.DataLayer
{
    public class ENTQuestionType : IEntity
    {
        public int ID { get; set; }
        public string TYPE { get; set; }
    }
}
