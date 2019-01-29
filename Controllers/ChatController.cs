using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Hubs;

namespace ckl.Controllers
{
    public class ChatController : Controller
    {
        public IHubContext<ChatHub, IChatClient> _strongChatHubContext { get; }
        public ChatController(IHubContext<ChatHub, IChatClient> chatHubContext)
        {
            _strongChatHubContext = chatHubContext;
        }

        public async Task SendMessage(string message)
        {
            await _strongChatHubContext.Clients.All.ReceiveMessage(message);
        }

        public Task SendMessageToCaller(string message)
        {
            return Clients.Caller.ReceiveMessage(message);
        }

        public Task SendMessageToGroup(string message)
        {
            return Clients.Group("SignalR Users").ReceiveMessage("ReceiveMessage", message);
        }
    }
}