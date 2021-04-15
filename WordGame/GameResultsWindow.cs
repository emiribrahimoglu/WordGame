using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace WordGame
{
    public partial class GameResultsWindow : Form
    {
        MySqlCommand command;
        int playerScoreAmountInDatabase;
        int playerScoreInDatabase;
        public GameResultsWindow(string playerName, string finalScore, string timeRemaining, string sessionDate)
        {
            InitializeComponent();
            playerNameLabel.Text = playerName;
            finalScoreLabel.Text = finalScore;
            timeRemainingLabel.Text = timeRemaining;
            sessionDateLabel.Text = sessionDate;
        }

        private void AddScoreToDatabase()
        {
            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;

            command.CommandText = "select count(*) from score_table where playerName=@playerName";
            command.Parameters.AddWithValue("@playerName", playerNameLabel.Text);
            playerScoreAmountInDatabase = Convert.ToInt32(command.ExecuteScalar());

            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;
            if (playerScoreAmountInDatabase > 0)
            {
                command.CommandText = "select score from score_table where playerName=@playerName";
                command.Parameters.AddWithValue("@playerName", playerNameLabel.Text);
                playerScoreInDatabase = Convert.ToInt32(command.ExecuteScalar());
                if (playerScoreInDatabase > int.Parse(finalScoreLabel.Text))
                {
                    goto skipAddingDatabase;
                }

                command = new MySqlCommand();
                command.Connection = MainMenuForm.connection;
                command.CommandText = "update score_table set score=@score where playerName=@playerName";
                command.Parameters.AddWithValue("@score", int.Parse(finalScoreLabel.Text));
                command.Parameters.AddWithValue("@playerName", playerNameLabel.Text);
                command.ExecuteNonQuery();
            }
            else
            {
                if (int.Parse(finalScoreLabel.Text) == 0)
                {
                    goto skipAddingDatabase;
                }
                command.CommandText = "insert into score_table(playerName,score) values(@playerName, @score)";
                command.Parameters.AddWithValue("@score", int.Parse(finalScoreLabel.Text));
                command.Parameters.AddWithValue("@playerName", playerNameLabel.Text);
                command.ExecuteNonQuery();
            }
        skipAddingDatabase:;
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GameResultsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddScoreToDatabase();
            MainMenuForm.mainMenuForm.WindowState = FormWindowState.Normal;
        }
    }
}
