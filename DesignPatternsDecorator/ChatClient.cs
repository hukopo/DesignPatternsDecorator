using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsDecorator
{
    public interface IChatClient
    {
        void SendMessage(Message message);
        List<Message> ReceiveMessages();
    }

    public class ChatClient : IChatClient
    {
        private readonly Stack<Message> _messagesStack = new Stack<Message>();
        public void SendMessage(Message message)
        {
            _messagesStack.Push(message);
        }

        public List<Message> ReceiveMessages()
        {
            return _messagesStack.ToList();
        }
    }
}