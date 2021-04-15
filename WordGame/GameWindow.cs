using System;
using System.Collections;
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
    public partial class GameWindow : Form
    {
        MySqlCommand command;
        int questionId = 1;
        int answerLength;
        int requestedLetterCount;

        int timerMinutes = 3;
        int timerSeconds = 60;

        int pauseTimerMinutes = 0;
        int pauseTimerSeconds = 20;

        int currentScore = 0;
        int earnableScore = 0;

        string question;

        ArrayList requestedLetters;
        ArrayList repeatedLetterIndexes;
        List<TextBox> letterSlotsList;
        char[] vowelList = new char[] { 'a', 'A', 'e', 'E', 'i', 'İ', 'ı', 'I', 'o', 'O', 'ö', 'Ö', 'u', 'U', 'ü', 'Ü' };
        public GameWindow()
        {
            InitializeComponent();
            letterSlotsList = new List<TextBox>();
            letterSlotsList.Add(letterSlot1);
            letterSlotsList.Add(letterSlot2);
            letterSlotsList.Add(letterSlot3);
            letterSlotsList.Add(letterSlot4);
            letterSlotsList.Add(letterSlot5);
            letterSlotsList.Add(letterSlot6);
            letterSlotsList.Add(letterSlot7);
            letterSlotsList.Add(letterSlot8);
            letterSlotsList.Add(letterSlot9);
            letterSlotsList.Add(letterSlot10);
        }

        private void CheckLetterSlots()
        {
            for (int i = 0; i < (letterSlotsList.Count-(letterSlotsList.Count-answerLength)); i++)
            {
                if (letterSlotsList[i].Text != "")
                {
                    requestedLetterCount++;
                }
            }
        }

        private void ShowWord(char[] wordArray)
        {
            for (int i = 0; i < wordArray.Length; i++)
            {
                letterSlotsList[i].Text = wordArray[i].ToString();
            }
        }

        private void RequestLetter()
        {
            string answerWord;
            char[] answerWordCharArray;
            bool doWhileControl = true;
            requestedLetterCount++;
            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;
            command.CommandText = "select answerWord from answers where question_id=@id";
            command.Parameters.AddWithValue("@id", questionId);
            answerWord = command.ExecuteScalar().ToString();

            answerWordCharArray = answerWord.ToCharArray();
            Random rnd = new Random();
            int rndm;
            do
            {
                if (pauseTimer.Enabled == true)
                {
                    ShowWord(answerWordCharArray);
                    break;
                }
                rndm = rnd.Next(0, answerLength);
                if (!requestedLetters.Contains(answerWordCharArray[rndm]))
                {
                    requestedLetters.Add(answerWordCharArray[rndm]);
                    //This Switch-Case handles putting requested letters into correct letterSlots
                    switch (rndm + 1)
                    {
                        case 1:
                            letterSlot1.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 2:
                            letterSlot2.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 3:
                            letterSlot3.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 4:
                            letterSlot4.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 5:
                            letterSlot5.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 6:
                            letterSlot6.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 7:
                            letterSlot7.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 8:
                            letterSlot8.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 9:
                            letterSlot9.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 10:
                            letterSlot10.Text = answerWordCharArray[rndm].ToString();
                            break;
                        default:
                            break;
                    }
                    repeatedLetterIndexes.Add(rndm);
                    earnableScore -= 100;
                    earnableScoreLabel.Text = earnableScore.ToString();
                    doWhileControl = false;
                }
                else if (vowelList.Contains(answerWordCharArray[rndm]) && !repeatedLetterIndexes.Contains(rndm))
                {
                    //This Switch-Case handles putting requested letters into correct letterSlots
                    switch (rndm + 1)
                    {
                        case 1:
                            letterSlot1.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 2:
                            letterSlot2.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 3:
                            letterSlot3.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 4:
                            letterSlot4.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 5:
                            letterSlot5.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 6:
                            letterSlot6.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 7:
                            letterSlot7.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 8:
                            letterSlot8.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 9:
                            letterSlot9.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 10:
                            letterSlot10.Text = answerWordCharArray[rndm].ToString();
                            break;
                        default:
                            break;
                    }
                    repeatedLetterIndexes.Add(rndm);
                    earnableScore -= 100;
                    earnableScoreLabel.Text = earnableScore.ToString();
                    doWhileControl = false;
                }
                else if (!repeatedLetterIndexes.Contains(rndm))
                {
                    //This Switch-Case handles putting requested letters into correct letterSlots
                    switch (rndm + 1)
                    {
                        case 1:
                            letterSlot1.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 2:
                            letterSlot2.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 3:
                            letterSlot3.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 4:
                            letterSlot4.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 5:
                            letterSlot5.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 6:
                            letterSlot6.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 7:
                            letterSlot7.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 8:
                            letterSlot8.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 9:
                            letterSlot9.Text = answerWordCharArray[rndm].ToString();
                            break;
                        case 10:
                            letterSlot10.Text = answerWordCharArray[rndm].ToString();
                            break;
                        default:
                            break;
                    }
                    repeatedLetterIndexes.Add(rndm);
                    earnableScore -= 100;
                    earnableScoreLabel.Text = earnableScore.ToString();
                    doWhileControl = false;
                }
            } while (doWhileControl);
            //Clean MySqlCommand just in case
            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;
        }

        private void EmptyLetterSlots()
        {
            letterSlot1.Text = string.Empty;
            letterSlot2.Text = string.Empty;
            letterSlot3.Text = string.Empty;
            letterSlot4.Text = string.Empty;
            letterSlot5.Text = string.Empty;
            letterSlot6.Text = string.Empty;
            letterSlot7.Text = string.Empty;
            letterSlot8.Text = string.Empty;
            letterSlot9.Text = string.Empty;
            letterSlot10.Text = string.Empty;
        }

        private void GetQuestionFromDatabase()
        {
            command.CommandText = "select question from questions where id=@id";
            command.Parameters.AddWithValue("@id", questionId);
            question = command.ExecuteScalar().ToString();

            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;
            command.CommandText = "update questions set isAskedBefore=@isAskedBefore where id=@id";
            command.Parameters.AddWithValue("@isAskedBefore", true);
            command.Parameters.AddWithValue("@id", questionId);

            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;
            command.CommandText = "select answerLetterCount from questions where id=@id";
            command.Parameters.AddWithValue("@id", questionId);
            answerLength = Convert.ToInt32(command.ExecuteScalar());
            earnableScore = answerLength * 100;
            earnableScoreLabel.Text = earnableScore.ToString();

            requestedLetters = new ArrayList();
            repeatedLetterIndexes = new ArrayList();
            requestedLetterCount = 0;

            questionRichTxt.Text = question;
            playerAnswerTxt.MaxLength = answerLength;

            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;

            /*
             * This switch-case handles showing answerLetterSlot Text Boxes at the same amount as length of answer word.
             * (5 Letter Word = 5 Text Boxes)
            */
            switch (answerLength)
            {
                case 5:
                    if (!letterSlot5.Visible) { letterSlot5.Visible = true; }
                    break;
                case 6:
                    if (!letterSlot6.Visible) { letterSlot6.Visible = true; }
                    break;
                case 7:
                    if (!letterSlot7.Visible) { letterSlot7.Visible = true; }
                    break;
                case 8:
                    if (!letterSlot8.Visible) { letterSlot8.Visible = true; }
                    break;
                case 9:
                    if (!letterSlot9.Visible) { letterSlot9.Visible = true; }
                    break;
                case 10:
                    if (!letterSlot10.Visible) { letterSlot10.Visible = true; }
                    break;
                default:
                    break;
            }
        }

        private void CheckAnswer()
        {
            command.CommandText = "select answerWord from answers where question_id=@id";
            command.Parameters.AddWithValue("@id", questionId);
            string answer = command.ExecuteScalar().ToString();
            if (playerAnswerTxt.Text.ToUpper(new CultureInfo("tr-TR", false)) == answer)
            {
                playerAnswerTxt.Enabled = false;
                playerAnswerTxt.Text = string.Empty;
                submitAnswerButton.BackColor = Color.Green;
                pauseTimer.Enabled = false;
                currentScore += earnableScore;
                currentScoreLabel.Text = string.Empty + currentScore;
                if (questionId != 14)
                {
                    questionId++;
                    pauseTimerSeconds = 20;
                    submitAnswerButton.Enabled = false;
                    command = new MySqlCommand();
                    command.Connection = MainMenuForm.connection;
                    if (!mainTimer.Enabled)
                    {
                        mainTimer.Enabled = true;
                        mainTimerLabel.Text = timerMinutes + ":" + timerSeconds.ToString("D2");
                        pauseTimer.Enabled = false;
                    }
                    GetQuestionFromDatabase();
                    EmptyLetterSlots();
                    requestLetterButton.Enabled = true;
                }
                else if (questionId == 14)
                {
                    mainTimer.Enabled = false;
                    pauseTimer.Enabled = false;
                    mainTimerLabel.Text = timerMinutes + ":" + timerSeconds.ToString("D2");
                    MessageBox.Show("THE GAME IS OVER! CLICK OK TO SEE YOUR RESULTS!", "YOU JUST BEAT THE GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GameResultsWindow grw = new GameResultsWindow(MainMenuForm.mainMenuForm.playerName, currentScore.ToString(), 
                        mainTimerLabel.Text, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString());

                    grw.Show();
                    Close();
                }
                
            }
            else
            {
                submitAnswerButton.BackColor = Color.Red;
                command = new MySqlCommand();
                command.Connection = MainMenuForm.connection;
            }
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;
            GetQuestionFromDatabase();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (submitAnswerButton.BackColor == Color.Green || submitAnswerButton.BackColor == Color.Red)
            {
                submitAnswerButton.BackColor = Color.DarkGray;
            }
            timerSeconds--;
            mainTimerLabel.Text = timerMinutes + ":" + timerSeconds.ToString("D2");
            if (timerSeconds == 00 && timerMinutes != 0)
            {
                timerMinutes--;
                timerSeconds = 60;
            }
            else if (timerSeconds == 00 && timerMinutes == 0)
            {
                mainTimer.Enabled = false;
                MessageBox.Show("TIME IS UP! YOU WEREN'T ABLE TO FINISH THE QUESTIONS IN TIME. HERE ARE THE RESULTS.", "TIME IS UP!");

                GameResultsWindow grw = new GameResultsWindow(MainMenuForm.mainMenuForm.playerName, currentScore.ToString(),
                        mainTimerLabel.Text, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString());

                grw.Show();
                Close();
            }
        }

        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void playerAnswerTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && playerAnswerTxt.Focused && submitAnswerButton.Enabled)
            {
                CheckAnswer();
            }
        }

        private void pauseTimerButton_Click(object sender, EventArgs e)
        {
            if (!pauseTimer.Enabled)
            {
                requestLetterButton.Enabled = false;
                playerAnswerTxt.Enabled = true;
                submitAnswerButton.Enabled = true;
                mainTimer.Enabled = false;
                pauseTimer.Enabled = true;
                mainTimerLabel.Text = pauseTimerMinutes + ":" + pauseTimerSeconds.ToString("D2");
            }
        }

        private void pauseTimer_Tick(object sender, EventArgs e)
        {
            pauseTimerSeconds--;
            mainTimerLabel.Text = pauseTimerMinutes + ":" + pauseTimerSeconds.ToString("D2");
            if (pauseTimerSeconds == 00)
            {
                playerAnswerTxt.Enabled = false;
                playerAnswerTxt.Text = string.Empty;
                currentScore -= earnableScore;
                if (currentScore < 0) { currentScore = 0; }
                currentScoreLabel.Text = currentScore.ToString();
                command = new MySqlCommand();
                command.Connection = MainMenuForm.connection;
                RequestLetter(); //It won't request another letter, it will straight-forward show the right word. Line 80
                if (questionId < 14)
                {
                    questionId++;
                }
                else
                {
                    pauseTimer.Enabled = false;
                    MessageBox.Show("QUESTIONS ARE DONE! HERE ARE THE RESULTS", "GAME SESSIONS IS OVER!");

                    GameResultsWindow grw = new GameResultsWindow(MainMenuForm.mainMenuForm.playerName, currentScore.ToString(),
                            mainTimerLabel.Text, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString());

                    grw.Show();
                    Close();
                }
                pauseTimerSeconds = 20;
                twentySecondsTimeoutTimer.Enabled = true;
                mainTimerLabel.Text = timerMinutes + ":" + timerSeconds.ToString("D2");
                submitAnswerButton.Enabled = false;
                pauseTimer.Enabled = false;
            }
        }

        private void requestLetterButton_Click(object sender, EventArgs e)
        {
            if (requestedLetterCount != answerLength)
            {
                RequestLetter();
            }
            
        }

        private void twentySecondsTimeoutTimer_Tick(object sender, EventArgs e)
        {
            mainTimer.Enabled = true;
            GetQuestionFromDatabase();
            EmptyLetterSlots();
            requestLetterButton.Enabled = true;
            twentySecondsTimeoutTimer.Enabled = false;
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm.mainMenuForm.WindowState = FormWindowState.Normal;
        }
    }
}
