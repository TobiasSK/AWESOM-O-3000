using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.Commands;

namespace DiscordBot
{
    public partial class Adminpanel : Form
    {
        private CommandEventArgs e;
        private DiscordClient client;

        public Adminpanel(DiscordClient client, CommandEventArgs e)
        {
            this.client = client;
            this.e = e;

            InitializeComponent();
        }

        private void kickTextbox_TextChanged(object sender, EventArgs e)
        {
            var usernameToKick = kickTextbox.Text;

            var userToKick = this.e.Channel.Users.Where(input => input.Name.ToUpper() == usernameToKick).FirstOrDefault();

            userToKick.Kick();
        }

        private void kickButton_Click(object sender, EventArgs e)
        {

        }
    }
}
