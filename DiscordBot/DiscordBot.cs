using Discord;
using Discord.Commands;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DiscordBot
{
    class DiscordBot
    {
        DiscordClient client;
        CommandService commands;
        CommandEventArgs adminPanelArgs;
        Form AdminPanel;

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

            client.ExecuteAndWait(async() =>
                { 
                await client.Connect("MTk3NDUzODUwNDY5MzM1MDUx.C2g1eg.SJtbmHXDhsIbxorIXjkxQV2VDLs", TokenType.Bot);
                });


            /* MULTITHREADED ADMIN PANEL*/
            commands.CreateCommand("adminpanel").Do((e) =>
            {
                AdminPanel = new Adminpanel(client, e);

                var thread = new Thread(OpenAdminPanel);

                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

            });



        }

        private void OpenAdminPanel()
        {
            Application.Run(AdminPanel);
        }



        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);

        }

        

        /*private void Play()
        {

        }

        private void SoundCollection()
        {
            
        }
        */


    }
}
