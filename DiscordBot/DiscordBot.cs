using Discord;
using Discord.Commands;
using System;
using System.Linq;
using System.Threading.Tasks;

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


            

            commands.CreateCommand("Niggah").Alias(new string[] { "yo", "homie" }).Do(async (e) =>
            {
                await e.Channel.SendMessage("Nigga, please!");
            });

            commands.CreateCommand("announce").Parameter("message", ParameterType.Unparsed).Do(async (e) =>
            {
                await DoAnnouncement(e);
            });

            client.UserJoined += async (s, e) =>
            {
                var channel = e.Server.FindChannels("gay-mers", ChannelType.Text).FirstOrDefault();

                var user = e.User;

                await channel.SendTTSMessage(string.Format("{0} has joined the channel!", user.Name));
            };

            client.UserLeft += async (s, e) =>
            {
                var channel = e.Server.FindChannels("gay-mers", ChannelType.Text).FirstOrDefault();

                var user = e.User;

                await channel.SendTTSMessage(string.Format("{0} has left the channel", user.Name));
            };


            client.ExecuteAndWait(async() =>
                { 
                await client.Connect("MTk3NDUzODUwNDY5MzM1MDUx.C2g1eg.SJtbmHXDhsIbxorIXjkxQV2VDLs", TokenType.Bot);
                });

        }

        private async Task DoAnnouncement(CommandEventArgs e)
        {
            var channel = e.Server.FindChannels(e.Args[0], ChannelType.Text).FirstOrDefault();

            var message = ConstructMessage(e, channel != null);

            if (channel != null)
            {
                await channel.SendMessage(message);
            }
            else
            {
                await e.Channel.SendMessage(message);
            }
        }

        private string ConstructMessage(CommandEventArgs e, bool firstArgIsChannel)
        {
            string message = "";

            var name = e.User.Nickname != null ? e.User.Nickname : e.User.Name;

            var starIndex = firstArgIsChannel ? 1 : 0;

            for (int i = starIndex; i < e.Args.Length; i++)
            {
                message += e.Args[i].ToString() + " ";
            }

            var result = name + " says: " + message;

            return result;

            
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);

        }
    }
}
