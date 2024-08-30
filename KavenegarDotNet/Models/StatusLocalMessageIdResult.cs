using KavenegarDotNet.Models.Enums;

namespace KavenegarDotNet.Models
{
 public class StatusLocalMessageIdResult
 {
	public long MessageId { get; set; }
	public long LocalId { get; set; }
	public MessageStatus Status { get; set; }
	public string StatusText { get; set; }
 }
}