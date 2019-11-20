using System.Security.Cryptography;

namespace DesignPatternsDecorator
{
    public class HidingUserDecorator : DecoratorBase
    {
        public HidingUserDecorator(IChatClient chatClient) : base(chatClient)
        {
        }

        public override Message BeforeSendingMessage(Message message)
        {
            message.Author = "*****";
            message.Addressee = "*****";
            return message;
        }
    }
}