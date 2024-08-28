using System.Collections.Generic;

namespace Kavenegar.Core.Models
{
    internal class ReturnCountPostalCode
    {
        public Result result { get; set; }
        public List<CountPostalCodeResult> entries { get; set; }
    }
}