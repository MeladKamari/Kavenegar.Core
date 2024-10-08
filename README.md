# Kavenegar Dot Net Client
A cross-platform library for the Kavenegar sms web service; written in C#.

## Installation
The package can be installed via [nuget](https://www.nuget.org/packages/KaveNegarDotNet):

##### Package Manager
```
Install-Package KavenegarDotNet -Version 1.0.2
```
##### .NET CLI
```
dotnet add package KavenegarDotNet --version 1.0.2
```

## Usage
Send SMS Example:

```c#
//In Program.cs or StartUp.cs Add KaveNegar to Dependency Injection
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddKaveNegar(config =>
{
    config.ApiKey="ApiKey";
} );
```
```c#
app.MapGet("/SendSmsWithKaveNegar", async (IKaveNegar kaveNegar) =>
    {
        var receptors = new List<string> { "<ReceptorNumber>" };
        var result = await kaveNegar.Send("<SenderNumber>", receptors, "<Message>");
        foreach (var r in result)
        {
            Console.Write($"{r.MessageId.ToString()}");
        }        
        return Results.Ok();
    })
    .WithName("SendSmsWithKaveNegar")
    .WithOpenApi();
```




<hr>
<div dir='rtl'>
	
## راهنما

### معرفی سرویس کاوه نگار

کاوه نگار یک وب سرویس ارسال و دریافت پیامک و تماس صوتی است که به راحتی میتوانید از آن استفاده نمایید.

### ساخت حساب کاربری

اگر در وب سرویس کاوه نگار عضو نیستید میتوانید از [لینک عضویت](http://panel.kavenegar.com/client/membership/register) ثبت نام  و اکانت آزمایشی برای تست API دریافت نمایید.

### مستندات

برای مشاهده اطلاعات کامل مستندات [وب سرویس پیامک](http://kavenegar.com/وب-سرویس-پیامک.html)  به صفحه [مستندات وب سرویس](http://kavenegar.com/rest.html) مراجعه نمایید.

### راهنمای فارسی

در صورتی که مایل هستید راهنمای فارسی کیت توسعه کاوه نگار را مطالعه کنید به صفحه [کد ارسال پیامک](http://kavenegar.com/sdk.html) مراجعه نمایید.

### اطالاعات بیشتر
برای مطالعه بیشتر به صفحه معرفی
[وب سرویس اس ام اس ](http://kavenegar.com)
کاوه نگار
مراجعه نمایید .

 اگر در استفاده از کیت های سرویس کاوه نگار مشکلی یا پیشنهادی  داشتید ما را با یک Pull Request  یا  ارسال ایمیل به meladhamedani@gmail.com  خوشحال کنید.

##
</div>



