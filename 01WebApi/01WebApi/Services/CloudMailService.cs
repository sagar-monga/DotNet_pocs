using System;
using _01WebApi.Interfaces;

namespace _01WebApi.Services;

/// <summary>
/// @deprecated use MailService instead
/// </summary>
public class CloudMailService : IMailService
{
    private readonly string _from = "mail@cloudmailservice.com";
    private readonly string _message = "Message from Cloud Mail Service";

    public string SendMail()
    {
        return $"Sending mail from {_from} with message: {_message}";
    }

}
