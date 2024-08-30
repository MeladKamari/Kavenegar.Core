using System.Collections.Generic;

namespace KavenegarDotNet.Models
{
    internal class ReturnCountOutbox
    {
        public Result result { get; set; }
        public List<CountOutboxResult> entries { get; set; }
    }
}