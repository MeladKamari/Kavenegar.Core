using System.Collections.Generic;

namespace KavenegarDotNet.Models
{
    internal class ReturnCountInbox
    {
        public Result result { get; set; }
        public List<CountInboxResult> entries { get; set; }
    }
}