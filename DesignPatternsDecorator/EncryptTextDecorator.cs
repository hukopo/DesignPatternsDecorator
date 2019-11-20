using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DesignPatternsDecorator
{
    public class EncryptTextDecorator : DecoratorBase
    {
        public EncryptTextDecorator(IChatClient chatClient) : base(chatClient)
        {
        }

        public override Message BeforeSendingMessage(Message message)
        {
            message.Text = $"<encrypted>{message.Text}</encrypted>";
            return message;
        }

        public override List<Message> AfterReceivingMessage(List<Message> messages)
        {
            foreach (var message in messages)
            {
                message.Text = Regex.Match(message.Text, "<encrypted>(.*)</encrypted>").Groups[1].Value;
            }

            return messages;
        }
    }
}