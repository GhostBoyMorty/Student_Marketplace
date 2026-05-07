using Microsoft.AspNetCore.SignalR;
using Student_Marketplace.Models;

namespace Student_Marketplace.Hubs
{
    public class ChatHub:Hub
    {
        // This method is called by the client (browser) to send a message
        public async Task SendMessageToUser(string user, string receiver, string message)
        {
            // We use your model here to keep things organized
            var chatEntry = new ChatsM
            {
                Sender = user,
                MessageContent = message,
                Timestamp = DateTime.Now
            };

            // This tells C# to send the message back to all connected browsers
            await Clients.All.SendAsync("ReceiveMessage", chatEntry.Sender, chatEntry.MessageContent);
        }


    

    }
}
