namespace OopPrinciples.Encapsulation;

public enum NotificationType
{
    Email,
    Sms
}

public interface INotificationService
{
    void SendNotification(NotificationType type, string message);
}

public class NotificationService : INotificationService
{
    public NotificationService(string fromEmailAddress)
    {
        _fromEmailAddress = fromEmailAddress;
        _fromName = "My App";
    }

    #region Using access modifiers

    private string _fromEmailAddress;
    private string _fromName;

    #endregion

    #region Using properties

    // public string FromEmailAddress
    // {
    //     get => _fromEmailAddress;
    //     set => _fromEmailAddress = value;
    // }

    #endregion

    #region Using getter and setter methods

    public string FromEmailAddress()
    {
        return _fromEmailAddress;
    }

    public void FromEmailAddress(string value)
    {
        _fromEmailAddress = value;
    }

    #endregion

    #region Using data hiding

    public void SetFromName(string name)
    {
        _fromName = name;
    }

    #endregion

    #region Using interfaces

    public void SendNotification(NotificationType type, string message)
    {
        var result = type switch
        {
            NotificationType.Email => SendEmailNotification(message),
            NotificationType.Sms => SendSmsNotification(message),
            _ => throw new NotImplementedException()
        };
    }

    #endregion

    #region Using encapsulation of complex behavior

    private bool SendEmailNotification(string message)
    {
        // Sending email notification
        return true;
    }

    private bool SendSmsNotification(string message)
    {
        // Sending sms notification
        return true;
    }

    #endregion
}