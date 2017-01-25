namespace DiscordBot
{
    partial class Adminpanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.kickTextbox = new System.Windows.Forms.TextBox();
            this.kickButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(255, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // kickTextbox
            // 
            this.kickTextbox.Location = new System.Drawing.Point(25, 68);
            this.kickTextbox.Name = "kickTextbox";
            this.kickTextbox.Size = new System.Drawing.Size(132, 22);
            this.kickTextbox.TabIndex = 1;
            this.kickTextbox.TextChanged += new System.EventHandler(this.kickTextbox_TextChanged);
            // 
            // kickButton
            // 
            this.kickButton.Location = new System.Drawing.Point(207, 68);
            this.kickButton.Name = "kickButton";
            this.kickButton.Size = new System.Drawing.Size(113, 23);
            this.kickButton.TabIndex = 2;
            this.kickButton.Text = "Kick User";
            this.kickButton.UseVisualStyleBackColor = true;
            this.kickButton.Click += new System.EventHandler(this.kickButton_Click);
            // 
            // Adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 430);
            this.Controls.Add(this.kickButton);
            this.Controls.Add(this.kickTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Adminpanel";
            this.Text = "Adminpanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kickTextbox;
        private System.Windows.Forms.Button kickButton;
    }
}