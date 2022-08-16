using Microsoft.AspNetCore.SignalR;

namespace Lab_One.Hubs
{
    public class ChatHub:Hub
    {
        //Dictionary<string, string> connectionIDs = new Dictionary<string, string>();
        public void SendMessagesToOnlineClients(string Message)
        {
            Clients.AllExcept(Context.ConnectionId).SendAsync("RecieveMessage", Context.User, Message);
            //Clients.All.SendAsync("RecieveMessage", Context.User, Message);
        }
        //public override Task OnConnectedAsync()
        //{
        //    connectionIDs[Context.ConnectionId] = Context.ConnectionId;
        //    return base.OnConnectedAsync();
        //}
    }
}
