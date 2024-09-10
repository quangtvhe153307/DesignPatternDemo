namespace ChainsOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IReceiver faxHandler, emailHandler;
            emailHandler = new EmailErrorHandler(null);
            faxHandler = new FaxErrorMessageHandler(emailHandler);

            IssueRaiser issueRaiser = new IssueRaiser(faxHandler);

            Message message1 = new Message(Priority.Normal, "Fax is reaching late in destination");
            Message message2 = new Message(Priority.High, "Emails are not reaching in destination");
            Message message3 = new Message(Priority.Normal, "In Email, CC field is disabled always");
            Message message4 = new Message(Priority.High, "Fax is not reaching in destination");

            issueRaiser.RaiseMessage(message1);
            issueRaiser.RaiseMessage(message2);
            issueRaiser.RaiseMessage(message3);
            issueRaiser.RaiseMessage(message4);

            Console.ReadKey();

        }
    }
}
