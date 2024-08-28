using System;
namespace Kavenegar.Core.Models
{
 public class AccountInfoResult
 {
	public long RemainCredit { get; set; }
	public long ExpireDate { get; set; }
	public DateTime GregorianExpireDate => Utils.DateHelper.UnixTimestampToDateTime(ExpireDate);
	public string Type { get; set; }
 }
}