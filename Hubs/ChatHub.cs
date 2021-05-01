using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;


namespace UruguayBus.Hubs
{
        public class ChatHub : Hub
        {  
        public async Task SendMessage(List<string> notificaciones)
        {
            await Clients.All.SendAsync("ReceiveMessage", notificaciones);
        }



    }
    
}
