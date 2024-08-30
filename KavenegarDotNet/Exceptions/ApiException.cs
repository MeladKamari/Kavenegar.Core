using KavenegarDotNet.Models.Enums;

namespace KavenegarDotNet.Exceptions
{
 public class ApiException : KavenegarException
 {
	readonly MetaCode _result;
	public ApiException(string message, int code)
	 : base(message)
	{
	 _result = (MetaCode)code;
	}

	public MetaCode Code => _result;
 }
}
