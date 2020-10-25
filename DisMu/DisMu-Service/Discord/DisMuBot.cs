using Discord;
using Discord.WebSocket;
using DisMu_Service.Classes;
using DisMu_Service.Manager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisMu_Service.Discord
{
    public class DisMuBot
    {
        public static bool DisMuBotStarted = false;
        public static DiscordSocketClient _client;
        public static IServiceProvider _services;
        private static Commands _commands;

        public static async Task StartDisMuBot()
        {
            try
            {
                _client = new DiscordSocketClient();
                _commands = new Commands();

                _services = new ServiceCollection()
                    .AddSingleton(_client)
                    .AddSingleton(_commands)
                    .BuildServiceProvider();

                _client.Log += _client_Log;

                _client.MessageReceived += HandleCommandAsync;

                await _client.LoginAsync(TokenType.Bot, SettingsManager.settings.DiscordToken);

                await _client.StartAsync();

                DisMuBotStarted = true;
            } catch (Exception ex)
            {
                Console.WriteLine("Exception in DisMuBot.StartDisMuBot...\n" + ex);
            }
        }

        private static async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            if (message.Author.IsBot)
            {
                return;
            }

            if (message.Content[0] == '!')
            {
                await _commands.handleCommandInput(message);
            }
        }

        private static Task _client_Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            return Task.CompletedTask;
        }

        
    }
}
