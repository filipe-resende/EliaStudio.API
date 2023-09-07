using Domain;

namespace Service
{
    public interface IEmailSenderService
    {
        void EmailSender(ClientInfo clientInfo);
    }
}
