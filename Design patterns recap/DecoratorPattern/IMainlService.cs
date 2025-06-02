namespace Design_patterns_recap.DecoratorPattern;

public interface IMailService
{
    bool SendMail(string message);
}

public class CloudMainService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($":Message : {message} sent via {nameof(CloudMainService)}");
        return true;
    }
}
public class OnPremiseMainService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($":Message : {message} sent via {nameof(OnPremiseMainService)}");
        return true;
    }
}
public abstract class MailServiceDecoratorBase : IMailService
{
    private readonly IMailService _mailService;

    public MailServiceDecoratorBase(IMailService mailService)
    {
        _mailService = mailService;
    }

    public virtual bool SendMail(string message)
    {
        return _mailService.SendMail(message);
    }
}
public class StaticMailService : MailServiceDecoratorBase
{
    public StaticMailService(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        Console.WriteLine($"Collecting statistics ins {nameof(StaticMailService)}");
        return base.SendMail(message);
    }
}
public class MessageDatabaseDecorator : MailServiceDecoratorBase
{
    public List<string> SentMessages { get; private set; } = new ();
    public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        if (base.SendMail(message))
        {
            SentMessages.Add(message);  
            return true;
        }
        return false;
    }
}