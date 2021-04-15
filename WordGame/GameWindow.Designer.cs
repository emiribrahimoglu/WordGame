
namespace WordGame
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.currentScoreStaticLabel = new System.Windows.Forms.Label();
            this.currentScoreLabel = new System.Windows.Forms.Label();
            this.earnableScoreStaticLabel = new System.Windows.Forms.Label();
            this.earnableScoreLabel = new System.Windows.Forms.Label();
            this.questionRichTxt = new System.Windows.Forms.RichTextBox();
            this.playerAnswerTxt = new System.Windows.Forms.TextBox();
            this.submitAnswerButton = new System.Windows.Forms.Button();
            this.pauseTimerButton = new System.Windows.Forms.Button();
            this.mainTimerLabel = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseTimer = new System.Windows.Forms.Timer(this.components);
            this.letterSlot1 = new System.Windows.Forms.TextBox();
            this.letterSlot2 = new System.Windows.Forms.TextBox();
            this.letterSlot3 = new System.Windows.Forms.TextBox();
            this.letterSlot4 = new System.Windows.Forms.TextBox();
            this.letterSlot5 = new System.Windows.Forms.TextBox();
            this.letterSlot6 = new System.Windows.Forms.TextBox();
            this.letterSlot7 = new System.Windows.Forms.TextBox();
            this.letterSlot8 = new System.Windows.Forms.TextBox();
            this.letterSlot9 = new System.Windows.Forms.TextBox();
            this.letterSlot10 = new System.Windows.Forms.TextBox();
            this.requestLetterButton = new System.Windows.Forms.Button();
            this.twentySecondsTimeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // currentScoreStaticLabel
            // 
            this.currentScoreStaticLabel.AutoSize = true;
            this.currentScoreStaticLabel.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreStaticLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentScoreStaticLabel.Location = new System.Drawing.Point(12, 53);
            this.currentScoreStaticLabel.Name = "currentScoreStaticLabel";
            this.currentScoreStaticLabel.Size = new System.Drawing.Size(125, 18);
            this.currentScoreStaticLabel.TabIndex = 0;
            this.currentScoreStaticLabel.Text = "Current Score";
            // 
            // currentScoreLabel
            // 
            this.currentScoreLabel.AutoSize = true;
            this.currentScoreLabel.Font = new System.Drawing.Font("Unispace", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentScoreLabel.Location = new System.Drawing.Point(64, 80);
            this.currentScoreLabel.Name = "currentScoreLabel";
            this.currentScoreLabel.Size = new System.Drawing.Size(15, 15);
            this.currentScoreLabel.TabIndex = 1;
            this.currentScoreLabel.Text = "0";
            // 
            // earnableScoreStaticLabel
            // 
            this.earnableScoreStaticLabel.AutoSize = true;
            this.earnableScoreStaticLabel.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnableScoreStaticLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.earnableScoreStaticLabel.Location = new System.Drawing.Point(12, 113);
            this.earnableScoreStaticLabel.Name = "earnableScoreStaticLabel";
            this.earnableScoreStaticLabel.Size = new System.Drawing.Size(134, 18);
            this.earnableScoreStaticLabel.TabIndex = 2;
            this.earnableScoreStaticLabel.Text = "Earnable Score";
            // 
            // earnableScoreLabel
            // 
            this.earnableScoreLabel.AutoSize = true;
            this.earnableScoreLabel.Font = new System.Drawing.Font("Unispace", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnableScoreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.earnableScoreLabel.Location = new System.Drawing.Point(64, 140);
            this.earnableScoreLabel.Name = "earnableScoreLabel";
            this.earnableScoreLabel.Size = new System.Drawing.Size(15, 15);
            this.earnableScoreLabel.TabIndex = 3;
            this.earnableScoreLabel.Text = "0";
            // 
            // questionRichTxt
            // 
            this.questionRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.questionRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionRichTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionRichTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.questionRichTxt.Location = new System.Drawing.Point(184, 13);
            this.questionRichTxt.Name = "questionRichTxt";
            this.questionRichTxt.ReadOnly = true;
            this.questionRichTxt.Size = new System.Drawing.Size(482, 114);
            this.questionRichTxt.TabIndex = 4;
            this.questionRichTxt.Text = "TEST";
            // 
            // playerAnswerTxt
            // 
            this.playerAnswerTxt.BackColor = System.Drawing.Color.DarkGray;
            this.playerAnswerTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerAnswerTxt.Enabled = false;
            this.playerAnswerTxt.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerAnswerTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.playerAnswerTxt.Location = new System.Drawing.Point(184, 135);
            this.playerAnswerTxt.Name = "playerAnswerTxt";
            this.playerAnswerTxt.Size = new System.Drawing.Size(182, 20);
            this.playerAnswerTxt.TabIndex = 5;
            this.playerAnswerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerAnswerTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playerAnswerTxt_KeyDown);
            // 
            // submitAnswerButton
            // 
            this.submitAnswerButton.BackColor = System.Drawing.Color.DarkGray;
            this.submitAnswerButton.Enabled = false;
            this.submitAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitAnswerButton.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAnswerButton.ForeColor = System.Drawing.Color.Black;
            this.submitAnswerButton.Location = new System.Drawing.Point(372, 132);
            this.submitAnswerButton.Name = "submitAnswerButton";
            this.submitAnswerButton.Size = new System.Drawing.Size(109, 23);
            this.submitAnswerButton.TabIndex = 6;
            this.submitAnswerButton.Text = "Submit Answer";
            this.submitAnswerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.submitAnswerButton.UseVisualStyleBackColor = false;
            this.submitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
            // 
            // pauseTimerButton
            // 
            this.pauseTimerButton.BackColor = System.Drawing.Color.DarkGray;
            this.pauseTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pauseTimerButton.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseTimerButton.ForeColor = System.Drawing.Color.Black;
            this.pauseTimerButton.Location = new System.Drawing.Point(487, 132);
            this.pauseTimerButton.Name = "pauseTimerButton";
            this.pauseTimerButton.Size = new System.Drawing.Size(111, 23);
            this.pauseTimerButton.TabIndex = 7;
            this.pauseTimerButton.Text = "Pause Timer";
            this.pauseTimerButton.UseVisualStyleBackColor = false;
            this.pauseTimerButton.Click += new System.EventHandler(this.pauseTimerButton_Click);
            // 
            // mainTimerLabel
            // 
            this.mainTimerLabel.AutoSize = true;
            this.mainTimerLabel.Font = new System.Drawing.Font("Unispace", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTimerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTimerLabel.Location = new System.Drawing.Point(44, 13);
            this.mainTimerLabel.Name = "mainTimerLabel";
            this.mainTimerLabel.Size = new System.Drawing.Size(64, 25);
            this.mainTimerLabel.TabIndex = 8;
            this.mainTimerLabel.Text = "4:00";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // pauseTimer
            // 
            this.pauseTimer.Interval = 1000;
            this.pauseTimer.Tick += new System.EventHandler(this.pauseTimer_Tick);
            // 
            // letterSlot1
            // 
            this.letterSlot1.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot1.Location = new System.Drawing.Point(184, 161);
            this.letterSlot1.MaxLength = 1;
            this.letterSlot1.Name = "letterSlot1";
            this.letterSlot1.ReadOnly = true;
            this.letterSlot1.Size = new System.Drawing.Size(30, 32);
            this.letterSlot1.TabIndex = 9;
            this.letterSlot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // letterSlot2
            // 
            this.letterSlot2.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot2.Location = new System.Drawing.Point(220, 161);
            this.letterSlot2.MaxLength = 1;
            this.letterSlot2.Name = "letterSlot2";
            this.letterSlot2.ReadOnly = true;
            this.letterSlot2.Size = new System.Drawing.Size(30, 32);
            this.letterSlot2.TabIndex = 10;
            this.letterSlot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // letterSlot3
            // 
            this.letterSlot3.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot3.Location = new System.Drawing.Point(256, 161);
            this.letterSlot3.MaxLength = 1;
            this.letterSlot3.Name = "letterSlot3";
            this.letterSlot3.ReadOnly = true;
            this.letterSlot3.Size = new System.Drawing.Size(30, 32);
            this.letterSlot3.TabIndex = 11;
            this.letterSlot3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // letterSlot4
            // 
            this.letterSlot4.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot4.Location = new System.Drawing.Point(292, 161);
            this.letterSlot4.MaxLength = 1;
            this.letterSlot4.Name = "letterSlot4";
            this.letterSlot4.ReadOnly = true;
            this.letterSlot4.Size = new System.Drawing.Size(30, 32);
            this.letterSlot4.TabIndex = 12;
            this.letterSlot4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // letterSlot5
            // 
            this.letterSlot5.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot5.Location = new System.Drawing.Point(328, 161);
            this.letterSlot5.MaxLength = 1;
            this.letterSlot5.Name = "letterSlot5";
            this.letterSlot5.ReadOnly = true;
            this.letterSlot5.Size = new System.Drawing.Size(30, 32);
            this.letterSlot5.TabIndex = 13;
            this.letterSlot5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterSlot5.Visible = false;
            // 
            // letterSlot6
            // 
            this.letterSlot6.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot6.Location = new System.Drawing.Point(364, 161);
            this.letterSlot6.MaxLength = 1;
            this.letterSlot6.Name = "letterSlot6";
            this.letterSlot6.ReadOnly = true;
            this.letterSlot6.Size = new System.Drawing.Size(30, 32);
            this.letterSlot6.TabIndex = 14;
            this.letterSlot6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterSlot6.Visible = false;
            // 
            // letterSlot7
            // 
            this.letterSlot7.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot7.Location = new System.Drawing.Point(400, 161);
            this.letterSlot7.MaxLength = 1;
            this.letterSlot7.Name = "letterSlot7";
            this.letterSlot7.ReadOnly = true;
            this.letterSlot7.Size = new System.Drawing.Size(30, 32);
            this.letterSlot7.TabIndex = 15;
            this.letterSlot7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterSlot7.Visible = false;
            // 
            // letterSlot8
            // 
            this.letterSlot8.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot8.Location = new System.Drawing.Point(436, 161);
            this.letterSlot8.MaxLength = 1;
            this.letterSlot8.Name = "letterSlot8";
            this.letterSlot8.ReadOnly = true;
            this.letterSlot8.Size = new System.Drawing.Size(30, 32);
            this.letterSlot8.TabIndex = 16;
            this.letterSlot8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterSlot8.Visible = false;
            // 
            // letterSlot9
            // 
            this.letterSlot9.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot9.Location = new System.Drawing.Point(472, 161);
            this.letterSlot9.MaxLength = 1;
            this.letterSlot9.Name = "letterSlot9";
            this.letterSlot9.ReadOnly = true;
            this.letterSlot9.Size = new System.Drawing.Size(30, 32);
            this.letterSlot9.TabIndex = 17;
            this.letterSlot9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterSlot9.Visible = false;
            // 
            // letterSlot10
            // 
            this.letterSlot10.BackColor = System.Drawing.Color.DarkGray;
            this.letterSlot10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letterSlot10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterSlot10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSlot10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.letterSlot10.Location = new System.Drawing.Point(508, 161);
            this.letterSlot10.MaxLength = 1;
            this.letterSlot10.Name = "letterSlot10";
            this.letterSlot10.ReadOnly = true;
            this.letterSlot10.Size = new System.Drawing.Size(30, 32);
            this.letterSlot10.TabIndex = 18;
            this.letterSlot10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterSlot10.Visible = false;
            // 
            // requestLetterButton
            // 
            this.requestLetterButton.BackColor = System.Drawing.Color.DarkGray;
            this.requestLetterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.requestLetterButton.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLetterButton.Location = new System.Drawing.Point(544, 161);
            this.requestLetterButton.Name = "requestLetterButton";
            this.requestLetterButton.Size = new System.Drawing.Size(122, 31);
            this.requestLetterButton.TabIndex = 19;
            this.requestLetterButton.Text = "Request Letter";
            this.requestLetterButton.UseVisualStyleBackColor = false;
            this.requestLetterButton.Click += new System.EventHandler(this.requestLetterButton_Click);
            // 
            // twentySecondsTimeoutTimer
            // 
            this.twentySecondsTimeoutTimer.Interval = 2500;
            this.twentySecondsTimeoutTimer.Tick += new System.EventHandler(this.twentySecondsTimeoutTimer_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(676, 202);
            this.Controls.Add(this.requestLetterButton);
            this.Controls.Add(this.letterSlot10);
            this.Controls.Add(this.letterSlot9);
            this.Controls.Add(this.letterSlot8);
            this.Controls.Add(this.letterSlot7);
            this.Controls.Add(this.letterSlot6);
            this.Controls.Add(this.letterSlot5);
            this.Controls.Add(this.letterSlot4);
            this.Controls.Add(this.letterSlot3);
            this.Controls.Add(this.letterSlot2);
            this.Controls.Add(this.letterSlot1);
            this.Controls.Add(this.mainTimerLabel);
            this.Controls.Add(this.pauseTimerButton);
            this.Controls.Add(this.submitAnswerButton);
            this.Controls.Add(this.playerAnswerTxt);
            this.Controls.Add(this.questionRichTxt);
            this.Controls.Add(this.earnableScoreLabel);
            this.Controls.Add(this.earnableScoreStaticLabel);
            this.Controls.Add(this.currentScoreLabel);
            this.Controls.Add(this.currentScoreStaticLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Game - Game Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameWindow_FormClosed);
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentScoreStaticLabel;
        private System.Windows.Forms.Label currentScoreLabel;
        private System.Windows.Forms.Label earnableScoreStaticLabel;
        private System.Windows.Forms.Label earnableScoreLabel;
        private System.Windows.Forms.RichTextBox questionRichTxt;
        private System.Windows.Forms.TextBox playerAnswerTxt;
        private System.Windows.Forms.Button submitAnswerButton;
        private System.Windows.Forms.Button pauseTimerButton;
        private System.Windows.Forms.Label mainTimerLabel;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer pauseTimer;
        private System.Windows.Forms.TextBox letterSlot1;
        private System.Windows.Forms.TextBox letterSlot2;
        private System.Windows.Forms.TextBox letterSlot3;
        private System.Windows.Forms.TextBox letterSlot4;
        private System.Windows.Forms.TextBox letterSlot5;
        private System.Windows.Forms.TextBox letterSlot6;
        private System.Windows.Forms.TextBox letterSlot7;
        private System.Windows.Forms.TextBox letterSlot8;
        private System.Windows.Forms.TextBox letterSlot9;
        private System.Windows.Forms.TextBox letterSlot10;
        private System.Windows.Forms.Button requestLetterButton;
        private System.Windows.Forms.Timer twentySecondsTimeoutTimer;
    }
}