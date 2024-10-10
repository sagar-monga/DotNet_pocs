using System;
using _01WebApi.Interfaces;

namespace _01WebApi.Services;

public class LocalMailService : IMailService
{
    private readonly string _from = "mail@localmailservice.com";
    private readonly string _message = "Message from Local Mail Service";

    public string SendMail()
    {
        return $"Sending mail from {_from} with message: {_message}";
    }

}
