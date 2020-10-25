using Discord.WebSocket;
using DisMu_Service.Managers;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DisMu_Service.Classes
{
    public static class Command_Help
    {
        public static async Task Execute(SocketUserMessage message)
        {
            try
            {
                string reply = "";
                MatchCollection values = new Regex(@"\d+").Matches(message.Content);

                if (values.Count == 0) //output possible commands (!help)
                {
                    foreach (CommandDef command in Commands.commands_def)
                    {
                        reply += "**" + command.index + " - " + command.name + "**" + "  " + command.syntax + "\n\n";
                    }

                    await ReplyManager.send_Async(message, "❓ - Helppage : Possible Commands - ❓", reply, false);
                }
                else //output help for given command (!help [index]
                {
                    bool commandFound = false;
                    int inputNumber = Int32.Parse(values[0].ToString());

                    string tmpCommandName = "";
                    foreach (CommandDef command in Commands.commands_def)
                    {
                        if (inputNumber == command.index)
                        {
                            tmpCommandName = command.name;
                            reply += "**Syntax: " + command.syntax + "**\n";
                            reply += command.description + "\n\n";
                            reply += "Beispiel: " + command.example;
                            commandFound = true;
                        }
                    }

                    if (commandFound)
                    {
                        await ReplyManager.send_Async(message, "❓ - Helppage : " + tmpCommandName + " - ❓", reply, false);
                    }
                    else
                    {
                        await ReplyManager.send_Async(message, "❓ - Hilfeseite : NoCommand - ❓", "Couldnt find a command with the given index... please try again", false);
                    }
                }
            }
            catch (Exception)
            {
                await ReplyManager.send_Async(message, "Exception occoured...", "Exception in Command_Help.Execute... Please try again with a different input...");
            }
        }
    }
}
