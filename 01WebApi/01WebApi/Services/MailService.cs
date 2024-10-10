using System;
using _01WebApi.Interfaces;

namespace _01WebApi.Services;

public class MailService : IMailService
{
    private readonly string _from = String.Empty;
    private readonly string _message = String.Empty;

    public MailService(IConfiguration config) {
        _from = config["MailService:from"];
        _message = config["MailService:message"];
    }

    public string SendMail()
    {
        return $"Sending mail from {_from} with message: {_message}";
    }
}
