using Discord;
using Discord.Commands;
using System;

namespace DiscordBot
{
    class DiscordBot
    {
        DiscordClient client;
        CommandService commands;

        public DiscordBot()
        {
            

            client = new DiscordClient(input =>
            {
                input.LogLevel = LogSeverity.Info;
                input.LogHandler = Log;
                
            });

            

            client.UsingCommands(input => {

                
                input.PrefixChar = '!';
                input.AllowMentionPrefix = true;
                input.HelpMode = HelpMode.Public;
            });

            commands = client.GetService<CommandService>();

            commands.CreateCommand("Hello").Alias(new string[] {"hi", "sup" }).Do(async (e) =>
            {
                await e.Channel.SendMessage("World");
            });

            client.ExecuteAndWait(async() =>
                { 
                await client.Connect("MTk3NDUzODUwNDY5MzM1MDUx.C2g1eg.SJtbmHXDhsIbxorIXjkxQV2VDLs", TokenType.Bot);
                });

        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);

        }
    }
}
