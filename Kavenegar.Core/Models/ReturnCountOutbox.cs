using System.Collections.Generic;

namespace Kavenegar.Core.Models
{
    internal class ReturnCountOutbox
    {
        public Result result { get; set; }
        public List<CountOutboxResult> entries { get; set; }
    }
}