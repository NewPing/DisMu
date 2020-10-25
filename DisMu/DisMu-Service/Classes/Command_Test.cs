using Discord.WebSocket;
using DisMu_Service.Managers;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DisMu_Service.Classes
{
    public static class Command_Test
    {
        public static async Task Execute(SocketUserMessage message)
        {
            try
            {
                await ReplyManager.send_Async(message, "TestCommand", "Yeeee - ran test command - u happy now?!", true);
            }
            catch (Exception)
            {
                await ReplyManager.send_Async(message, "Exception occoured...", "Exception in Command_Help.Execute... Please try again with a different input...");
            }
        }
    }
}
