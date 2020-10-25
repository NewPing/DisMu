using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisMu_Service.Managers
{
    public static class ReplyManager
    {
        public static int maxReplyLength = 1000;
        public static Color messageColor = Color.DarkPurple;

        public static async Task send_Async(SocketMessage message, string caption, string replyText)
        {
            await sendSplitMessage(
                message,
                caption,
                replyText,
                messageColor,
                true
                );
        }

        public static async Task send_Async(SocketMessage message, string caption, string replyText, bool showAuthor)
        {
            await sendSplitMessage(
                message,
                caption,
                replyText,
                messageColor,
                showAuthor
                );
        }

        private static async Task sendSplitMessage(SocketMessage message, string caption, string replyText, Color color, bool showAuthor)
        {
            if (!String.IsNullOrWhiteSpace(replyText))
            {
                var splitString = splitIntoChunks(replyText, maxReplyLength);

                //send first block
                Embed embed = null;
                if (showAuthor)
                {
                    embed = new EmbedBuilder()
                    .WithAuthor(message.Author)
                    .WithColor(color)
                    .WithTitle(caption)
                    .WithDescription(splitString[0])
                    .Build();
                }
                else
                {
                    embed = new EmbedBuilder()
                    .WithColor(color)
                    .WithTitle(caption)
                    .WithDescription(splitString[0])
                    .Build();
                }

                await message.Channel.SendMessageAsync("", false, embed);

                //send following blocks
                for (int i = 1; i < splitString.Count; i++)
                {
                    embed = new EmbedBuilder()
                    .WithColor(color)
                    .WithDescription(splitString[0])
                    .Build();

                    await message.Channel.SendMessageAsync("", false, embed);
                }
            }
            else
            {
                Embed embed = new EmbedBuilder()
                    .WithAuthor(message.Author)
                    .WithColor(color)
                    .WithTitle(caption)
                    .WithDescription("")
                    .Build();

                await message.Channel.SendMessageAsync("", false, embed);
            }
        }

        public static List<string> splitIntoChunks(string str, int maxChunkSize)
        {
            List<string> chunks = new List<string>();
            for (int i = 0; i < str.Length; i += maxChunkSize)
            {
                chunks.Add(str.Substring(i, Math.Min(maxChunkSize, str.Length - i)));
            }
            return chunks;
        }
    }
}
