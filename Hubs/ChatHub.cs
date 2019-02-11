using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string email, DateTime dob)
        {
            await Clients.All.SendAsync("ReceiveMessage", email, dob);
        }
    }
}