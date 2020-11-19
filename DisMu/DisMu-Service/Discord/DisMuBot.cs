using Discord;
using Discord.WebSocket;
using DisMu_Service.Classes;
using DisMu_Service.Manager;
using Lavalink4NET;
using Lavalink4NET.DiscordNet;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Victoria;

namespace DisMu_Service.Discord
{
    public class DisMuBot
    {
        public static bool DisMuBotStarted = false;
        public static DiscordSocketClient _client;
        public static IServiceProvider _services;
        public static LavalinkNode _audioService;
        private static Commands _commands;
        public static LavaNode _lavaNode;

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

                //Victoria related stuff
                var services = new ServiceCollection()
                // Other services DiscordSocketClient, CommandService, etc
                .AddLavaNode(x => {
                    x.SelfDeaf = false;
                });

                LavaConfig lavaConfig = new LavaConfig();

                _lavaNode = new LavaNode(_client, lavaConfig);

                _client.Ready += () =>
                {
                    if (!_lavaNode.IsConnected)
                    {
                        _lavaNode.ConnectAsync();

                    }
                    return Task.CompletedTask;
                };

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
