using Discord.WebSocket;
using DisMu_Service.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisMu_Service.Classes
{
    public class Commands
    {
        public static List<CommandDef> commands_def = new List<CommandDef>();
        public Commands()
        {
            initializeCommands();
        }

        private void initializeCommands()
        {
            commands_def.Add(new CommandDef(
                @"^!help(:?((:?( )?)[0-9]+)?)$",
                "Help",
                "!help (index)",
                "Prints the helppage",
                "!help 1",
                Command_Help.Execute));

            commands_def.Add(new CommandDef(
                    @"^!test$",
                    "Testcommand",
                    "!test",
                    "Runs the Testcommand",
                    "!test",
                Command_Test.Execute));
        }

        public async Task handleCommandInput(SocketUserMessage message)
        {
            try
            {
                bool commandFound = false;

                foreach (CommandDef command in commands_def) //run through possible Commands 
                {
                    if (command.matchPattern.IsMatch(message.Content.ToLower()))
                    {
                        commandFound = true;
                        await command.function(message);
                    }
                }

                if (commandFound == false)
                {
                    await ReplyManager.send_Async(message, "Syntax Error", "Couldnt find a command with this syntax... type !help to get a list all possible commands");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                await ReplyManager.send_Async(message, "Critical Exception Occoured!", "");
            }
        }
    }
}
