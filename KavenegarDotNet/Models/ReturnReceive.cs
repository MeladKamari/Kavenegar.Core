using System.Collections.Generic;

namespace KavenegarDotNet.Models
{
    internal class ReturnReceive
    {
        public Result result { get; set; }
        public List<ReceiveResult> entries { get; set; }
    }
}