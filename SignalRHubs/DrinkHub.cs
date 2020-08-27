using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Red_River.SignalRHubs
{
    public class DrinkHub : Hub
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}