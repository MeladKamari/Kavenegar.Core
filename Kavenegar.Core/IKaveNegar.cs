using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kavenegar.Core.Models;
using Kavenegar.Core.Models.Enums;

namespace Kavenegar.Core
{
    public interface IKaveNegar
    {
        Task<List<SendResult>> Send(string sender, List<string> receptor, string message);
        Task<SendResult> Send(string sender, string receptor, string message);
        Task<SendResult> Send(string sender, string receptor, string message, MessageType type, DateTime date);

        Task<List<SendResult>> Send(string sender, List<string> receptor, string message, MessageType type,
            DateTime date);

        Task<SendResult> Send(string sender, string receptor, string message, MessageType type, DateTime date,
            string localid);

        Task<SendResult> Send(string sender, string receptor, string message, string localid);
        Task<List<SendResult>> Send(string sender, List<string> receptors, string message, string localid);

        Task<List<SendResult>> Send(string sender, List<string> receptor, string message, MessageType type,
            DateTime date, List<string> localids);

        Task<List<SendResult>> SendArray(List<string> senders, List<string> receptors, List<string> messages);

        Task<List<SendResult>> SendArray(string sender, List<string> receptors, List<string> messages, MessageType type,
            DateTime date);

        Task<List<SendResult>> SendArray(string sender, List<string> receptors, List<string> messages, MessageType type,
            DateTime date, string localmessageids);

        Task<List<SendResult>> SendArray(string sender, List<string> receptors, List<string> messages,
            string localmessageid);

        Task<List<SendResult>> SendArray(List<string> senders, List<string> receptors, List<string> messages,
            string localmessageid);

        Task<List<SendResult>> SendArray(List<string> senders, List<string> receptors, List<string> messages,
            List<MessageType> types, DateTime date, List<string> localmessageids);

        Task<List<StatusResult>> Status(List<string> messageids);
        Task<StatusResult> Status(string messageid);
        Task<List<StatusLocalMessageIdResult>> StatusLocalMessageId(List<string> messageids);
        Task<StatusLocalMessageIdResult> StatusLocalMessageId(string messageid);
        Task<List<SendResult>> Select(List<string> messageids);
        Task<SendResult> Select(string messageId);
        Task<List<SendResult>> SelectOutbox(DateTime startdate);
        Task<List<SendResult>> SelectOutbox(DateTime startdate, DateTime enddate);
        Task<List<SendResult>> SelectOutbox(DateTime startdate, DateTime enddate, string sender);
        Task<List<SendResult>> LatestOutbox(long pagesize);
        Task<List<SendResult>> LatestOutbox(long pagesize, string sender);
        Task<CountOutboxResult> CountOutbox(DateTime startdate);
        Task<CountOutboxResult> CountOutbox(DateTime startdate, DateTime enddate);
        Task<CountOutboxResult> CountOutbox(DateTime startdate, DateTime enddate, int status);
        Task<List<StatusResult>> Cancel(List<string> ids);
        Task<StatusResult> Cancel(string messageid);
        Task<List<ReceiveResult>> Receive(string line, int isread);
        Task<CountInboxResult> CountInbox(DateTime startdate, string linenumber);
        Task<CountInboxResult> CountInbox(DateTime startdate, DateTime enddate, string linenumber);
        Task<CountInboxResult> CountInbox(DateTime startdate, DateTime enddate, string linenumber, int isread);
        Task<List<CountPostalCodeResult>> CountPostalCode(long postalcode);

        Task<List<SendResult>> SendByPostalCode(long postalcode, string sender, string message, long mcistartIndex,
            long mcicount, long mtnstartindex, long mtncount);

        Task<List<SendResult>> SendByPostalCode(long postalcode, string sender, string message, long mcistartIndex,
            long mcicount, long mtnstartindex, long mtncount, DateTime date);

        Task<AccountInfoResult> AccountInfo();

        Task<AccountConfigResult> AccountConfig(string apilogs, string dailyreport, string debugmode,
            string defaultsender, int? mincreditalarm, string resendfailed);

        Task<SendResult> VerifyLookup(string receptor, string token, string template);
        Task<SendResult> VerifyLookup(string receptor, string token, string template, VerifyLookupType type);
        Task<SendResult> VerifyLookup(string receptor, string token, string token2, string token3, string template);

        Task<SendResult> VerifyLookup(string receptor, string token, string token2, string token3, string token10,
            string template);

        Task<SendResult> VerifyLookup(string receptor, string token, string token2, string token3, string template,
            VerifyLookupType type);

        Task<SendResult> VerifyLookup(string receptor, string token, string token2, string token3, string token10,
            string template, VerifyLookupType type);

        Task<SendResult> VerifyLookup(string receptor, string token, string token2, string token3, string token10,
            string token20, string template, VerifyLookupType type);

        #region << CallMakeTTS >>

        Task<SendResult> CallMakeTTS(string message, string receptor);
        Task<List<SendResult>> CallMakeTTS(string message, List<string> receptor);
        Task<List<SendResult>> CallMakeTTS(string message, List<string> receptor, DateTime? date, List<string> localid);

        #endregion << CallMakeTTS >>
    }
}