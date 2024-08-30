using System.Collections.Generic;

namespace KavenegarDotNet.Models
{
    internal class ReturnCountPostalCode
    {
        public Result result { get; set; }
        public List<CountPostalCodeResult> entries { get; set; }
    }
}