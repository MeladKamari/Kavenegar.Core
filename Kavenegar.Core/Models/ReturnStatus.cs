﻿using System.Collections.Generic;

namespace Kavenegar.Core.Models
{
    internal class ReturnStatus
    {
        public Result result { get; set; }
        public List<StatusResult> entries { get; set; }
    }
}