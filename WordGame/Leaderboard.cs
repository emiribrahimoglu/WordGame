using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace WordGame
{
    public partial class Leaderboard : Form
    {
        MySqlCommand command;
        string[] playerNames;
        int[] playerScores;
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void ShowLeaderboard()
        {
            int index = 0;
            try
            {
                command.CommandText = "select playerName from score_table order by score desc limit 3";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        playerNames[index] = reader[0].ToString();
                        index++;
                    }
                }
                index = 0;
                command.CommandText = "select score from score_table order by score desc limit 3";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        playerScores[index] = Convert.ToInt32(reader[0]);
                        index++;
                    }
                }
                playerNameLabel1.Text = playerNames[0];
                scoreLabel1.Text = playerScores[0].ToString();
                playerNameLabel2.Text = playerNames[1];
                scoreLabel2.Text = playerScores[1].ToString();
                playerNameLabel3.Text = playerNames[2];
                scoreLabel3.Text = playerScores[2].ToString();

            }
            catch (Exception)
            { MessageBox.Show("An error has occurred. Score database might be empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;
            playerNames = new string[3];
            playerScores = new int[3];
            ShowLeaderboard();
        }

        private void Leaderboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm.mainMenuForm.WindowState = FormWindowState.Normal;
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
