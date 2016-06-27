﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class LogDTO
    {
        public int LogId { get; set; }

        public string LogText { get; set; }

        public DateTime? Added { get; set; }

        public DateTime? Deleted { get; set; }

        public DateTime? Updated { get; set; }
    }
}