using Discord;
using Discord.WebSocket;
using DisMu_Service.Discord;
using DisMu_Service.Managers;
using Lavalink4NET.Rest;
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
                var voiceState = message.Author as IVoiceState;
                if (voiceState?.VoiceChannel == null)
                {
                    await ReplyManager.send_Async(message, "Info", "You must be connected to voice channel", true);
                    return;
                }

                await DisMuBot._lavaNode.JoinAsync(voiceState.VoiceChannel, message.Channel as ITextChannel);
                await ReplyManager.send_Async(message, "Info", $"Joined {voiceState.VoiceChannel.Name}!", true);

                //var track = await DisMuBot._audioService.GetTrackAsync("Coldplay - Adventure of a Lifetime", SearchMode.YouTube);

                //var reply = "";

                //reply += track.Author + "\n";
                //reply += track.Title + "\n";
                //reply += track.Source + "\n";
                //reply += track.Duration + "\n";
                //reply += track.IsLiveStream + "\n";
                //reply += track.IsSeekable + "\n";
                //reply += track.TrackIdentifier + "\n";
                //reply += track.Provider + "\n";
                //reply += track.Identifier + "\n";

                //await ReplyManager.send_Async(message, "TestCommand", "Yeeee - ran test command - u happy now?!", true);
                //await ReplyManager.send_Async(message, "TestCommand", reply, true);
            }
            catch (Exception e)
            {
                await ReplyManager.send_Async(message, "Exception occoured...", "Exception in Command_Help.Execute... Please try again with a different input...");
            }
        }
    }
}
