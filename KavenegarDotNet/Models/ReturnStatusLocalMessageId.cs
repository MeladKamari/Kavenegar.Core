using System.Collections.Generic;

namespace KavenegarDotNet.Models
{
    internal class ReturnStatusLocalMessageId
    {
        public Result result { get; set; }
        public List<StatusLocalMessageIdResult> entries { get; set; }
    }
}