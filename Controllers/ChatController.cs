using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ckl.Data;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Hubs;

namespace ckl.Controllers
{
    public class ChatController : Controller
    {
        public IHubContext<ChatHub, IChatClient> _strongChatHubContext { get; }
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISaturnReportRepository _saturnReportRepository;
        private readonly IRequestRepository _requestRepository;

        public ChatController(
            IHubContext<ChatHub,
            IChatClient> chatHubContext,
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            ISaturnReportRepository saturnReportRepository,
            IRequestRepository requestRepository
            )
        {
            _strongChatHubContext = chatHubContext;
            _signInManager = signInManager;
            _userManager = userManager;
            _saturnReportRepository = saturnReportRepository;         
        }


       
        [HttpPost]
        public async Task<IActionResult> SendMessageToCaller(string message)
        {
           await _strongChatHubContext.Clients.All.ReceiveMessage(message);
            return Accepted();
        }

        //public Task SendMessageToGroup(string message)
        //{
        //    return _strongChatHubContext.Clients.Group("SignalR Users").ReceiveMessage("ReceiveMessage", message);
        //}
    }
}