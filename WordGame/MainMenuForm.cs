using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WordGame
{
    public partial class MainMenuForm : Form
    {
        public static MySqlConnection connection;
        public static MainMenuForm mainMenuForm;
        public string playerName;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("server=localhost;user id=root;database=wordgamedatabase;Password=1234");
                connection.Open();
                mainMenuForm = this;
            }
            catch (Exception) { }
            
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(connection.State.ToString());
        }

        private void questionsPanelButton_Click(object sender, EventArgs e)
        {
            QuestionsManagementForm questionsManagementForm = new QuestionsManagementForm();
            questionsManagementForm.Show();
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            if (playerNameTxt.Text != string.Empty)
            {
                playerName = playerNameTxt.Text.ToUpper(new CultureInfo("tr-TR", false));
                GameWindow gw = new GameWindow();
                gw.Show();
                playerNameTxt.Text = string.Empty;
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show("YOU HAVE TO ENTER PLAYER NAME IN ORDER TO START THE GAME!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            Leaderboard lb = new Leaderboard();
            lb.Show();
            WindowState = FormWindowState.Minimized;
        }
    }
}
