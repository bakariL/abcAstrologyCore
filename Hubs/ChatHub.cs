using ckl.Data;
using ckl.Models;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(string firstName, string lastName);
        Task ReceiveMessage(string message);
    }
    public class ChatHub : Hub<IChatClient>
    {
        private readonly ApplicationDbContext _context;
        private readonly ISaturnReportRepository _saturnReportRepository;
        private readonly IRequestRepository _requestRepository;

        public ChatHub(
            ApplicationDbContext context, 
            ISaturnReportRepository saturnReportRepository,
            IRequestRepository requestRepository
            )
        {
            _context = context;
            _saturnReportRepository = saturnReportRepository;
            _requestRepository = requestRepository;
        }

        public async Task SendMessage(string firstName, string lastName, DateTime dob, string email, string gender)
        {
            var model = new Request();
            model.UserFirstName = firstName;
            model.UserLastName = lastName;
            model.UserDOB = dob;
            model.Email = email;
            model.Gender = gender;
            _requestRepository.Add(model);
            var allRequests = _requestRepository.GetAll();
            model.Count = _requestRepository.CountAll(allRequests);
            await Clients.All.ReceiveMessage(firstName, lastName);
        }

        public Task SendMessageToCaller(string message)
        {
            return Clients.Caller.ReceiveMessage(message);
        }

        //public Task SendMessageToGroup(string message)
        //{
        //    return Clients.Group("SignalR Users").ReceiveMessage("ReceiveMessage", firstName, lastName, dob, email, gender);
        //}

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}