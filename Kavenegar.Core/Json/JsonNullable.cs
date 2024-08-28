using System;

namespace Kavenegar.Core.Json
{
 public class JsonNullable : JsonObject
 {
	public String Nullable { get; set; } = "Null";

	public JsonObject UpCast()
	{
	 JsonObject objectJ = this;
	 return objectJ;
	}
 }
}
