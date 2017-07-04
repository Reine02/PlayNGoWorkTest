using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace OSGP_BMM.Hubs
{
    public class MessageHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.addNewMessageToPage(message);
        } 
    }
}