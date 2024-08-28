using System.Collections.Generic;

namespace Kavenegar.Core.Models
{
    internal class ReturnCountInbox
    {
        public Result result { get; set; }
        public List<CountInboxResult> entries { get; set; }
    }
}