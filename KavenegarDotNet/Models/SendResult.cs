using System;
using KavenegarDotNet.Utils;

namespace KavenegarDotNet.Models
{
 public class SendResult
 {
	public long MessageId { get; set; }

	public int Cost { get; set; }

	public DateTime GregorianDate
	{
	 get => DateHelper.UnixTimestampToDateTime(Date);
	 set => Date = DateHelper.DateTimeToUnixTimestamp(value);
	}
	
	public long Date { get; set; }

	public string Message { get; set; }

	public string Receptor { get; set; }

	public string Sender { get; set; }
	public int Status { get; set; }

	public string StatusText { get; set; }
 }
}