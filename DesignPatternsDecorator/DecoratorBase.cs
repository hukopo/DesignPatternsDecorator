using System.Collections.Generic;

namespace DesignPatternsDecorator
{
    public class DecoratorBase : IChatClient
    {
            private readonly IChatClient _chatClient;

            protected DecoratorBase(IChatClient chatClient)
            {
                _chatClient = chatClient;
            }

            public void SendMessage(Message message)
            {
                message = BeforeSendingMessage(message);
                _chatClient.SendMessage(message);
            }

            public List<Message> ReceiveMessages()
            {
                return AfterReceivingMessage(_chatClient.ReceiveMessages());
            }

            public virtual Message BeforeSendingMessage(Message message)
            {
                return message;
            }

            public virtual List<Message> AfterReceivingMessage(List<Message> messages)
            {
                return messages;
            }
        }
}