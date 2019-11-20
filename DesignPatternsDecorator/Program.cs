using System;

namespace DesignPatternsDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message() {Author = "1", Addressee = "2", Text = "3"};
            var client = (new EncryptTextDecorator(new HidingUserDecorator(new ChatClient()))) as IChatClient;
            client.SendMessage(message);
            var messages = client.ReceiveMessages();
            foreach (var m in messages)
            {
                Console.WriteLine($"Author: {m.Author} Addressee: {m.Addressee} Text: {m.Text}");
            }
        }
    }
}