using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebApi.Chat
{
    public class ChatHub : Hub
    {
        //SendMsg用于前端调用
        public Task SendMsg(ChatMessageInfo info)
        {
            //在客户端实现此处的Show方法
            return Clients.All.SendAsync("Show", info.UserName + ":" + info.Message);
        }
    }
}
