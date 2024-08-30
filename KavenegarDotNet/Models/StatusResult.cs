using KavenegarDotNet.Models.Enums;

namespace KavenegarDotNet.Models
{
 public class StatusResult
 {
	public long MessageId { get; set; }
	public MessageStatus Status { get; set; }
	public string StatusText { get; set; }
 }
}