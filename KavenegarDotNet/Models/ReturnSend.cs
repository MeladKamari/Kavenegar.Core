﻿using System.Collections.Generic;

namespace KavenegarDotNet.Models
{
    internal class ReturnSend
    {
        public Result @Return { get; set; }
        public List<SendResult> entries { get; set; }
    }
}