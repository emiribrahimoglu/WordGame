
namespace WordGame
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.questionsPanelButton = new System.Windows.Forms.Button();
            this.playGameButton = new System.Windows.Forms.Button();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameTxt = new System.Windows.Forms.TextBox();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionsPanelButton
            // 
            this.questionsPanelButton.BackColor = System.Drawing.Color.DarkGray;
            this.questionsPanelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.questionsPanelButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.questionsPanelButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.questionsPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.questionsPanelButton.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionsPanelButton.Location = new System.Drawing.Point(38, 159);
            this.questionsPanelButton.Name = "questionsPanelButton";
            this.questionsPanelButton.Size = new System.Drawing.Size(225, 76);
            this.questionsPanelButton.TabIndex = 0;
            this.questionsPanelButton.Text = "Manage Questions and Words";
            this.questionsPanelButton.UseVisualStyleBackColor = false;
            this.questionsPanelButton.Click += new System.EventHandler(this.questionsPanelButton_Click);
            // 
            // playGameButton
            // 
            this.playGameButton.BackColor = System.Drawing.Color.DarkGray;
            this.playGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playGameButton.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameButton.Location = new System.Drawing.Point(38, 241);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(225, 79);
            this.playGameButton.TabIndex = 1;
            this.playGameButton.Text = "Start The Game";
            this.playGameButton.UseVisualStyleBackColor = false;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.BackColor = System.Drawing.Color.DarkGray;
            this.testConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testConnectionButton.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testConnectionButton.Location = new System.Drawing.Point(12, 352);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(123, 29);
            this.testConnectionButton.TabIndex = 2;
            this.testConnectionButton.Text = "Test Connection";
            this.testConnectionButton.UseVisualStyleBackColor = false;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Player\'s Name";
            // 
            // playerNameTxt
            // 
            this.playerNameTxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playerNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerNameTxt.Font = new System.Drawing.Font("Unispace", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.playerNameTxt.Location = new System.Drawing.Point(85, 42);
            this.playerNameTxt.Name = "playerNameTxt";
            this.playerNameTxt.Size = new System.Drawing.Size(130, 23);
            this.playerNameTxt.TabIndex = 4;
            this.playerNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.BackColor = System.Drawing.Color.DarkGray;
            this.leaderboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.leaderboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.leaderboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.leaderboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leaderboardButton.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardButton.Location = new System.Drawing.Point(38, 77);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(225, 76);
            this.leaderboardButton.TabIndex = 5;
            this.leaderboardButton.Text = "Leaderboard";
            this.leaderboardButton.UseVisualStyleBackColor = false;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(309, 393);
            this.Controls.Add(this.leaderboardButton);
            this.Controls.Add(this.playerNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testConnectionButton);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.questionsPanelButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Game - Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button questionsPanelButton;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerNameTxt;
        private System.Windows.Forms.Button leaderboardButton;
    }
}

