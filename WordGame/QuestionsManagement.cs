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
    public partial class QuestionsManagementForm : Form
    {
        MySqlCommand command;
        public QuestionsManagementForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionFromDatabase()
        {
            if (questionsList.Items.Count > 0)
            {
                string selectedQuestion = questionsList.GetItemText(questionsList.SelectedItem);
                command.CommandText = "select id from questions where question=@question";
                command.Parameters.AddWithValue("@question", selectedQuestion);
                int id = Convert.ToInt32(command.ExecuteScalar());

                command = new MySqlCommand();
                command.Connection = MainMenuForm.connection;

                command.CommandText = "delete from answers where question_id=@question_id";
                command.Parameters.AddWithValue("@question_id", id);
                command.ExecuteNonQuery();

                command = new MySqlCommand();
                command.Connection = MainMenuForm.connection;

                command.CommandText = "delete from questions where id=@id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                command = new MySqlCommand();
                command.Connection = MainMenuForm.connection;
                FillLists();
            }
            else
            {
                MessageBox.Show("Questions List can't be empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillLists()
        {
            this.answersTableAdapter.Fill(this.wordgamedatabaseDataSet1.answers);
            this.questionsTableAdapter.Fill(this.wordgamedatabaseDataSet.questions);
        }

        private void QuestionsManagementForm_Load(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;
        }

        private void getListItemsButton_Click(object sender, EventArgs e)
        {
            FillLists();
        }

        private void addToDatabaseButton_Click(object sender, EventArgs e)
        {
            if (questionRichTxt.Text == "" || answerWordTxt.Text == "")
            {
                MessageBox.Show("YOU CAN'T LEAVE ANY OF THE QUESTION AND ANSWER TEXT BOXES EMPTY!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    command.CommandText = "insert into questions(question,answerLetterCount,isAskedBefore) values(@question, @answerLetterCount, @isAskedBefore)";
                    command.Parameters.AddWithValue("@question", questionRichTxt.Text.ToUpper(new CultureInfo("tr-TR", false)));
                    command.Parameters.AddWithValue("@answerLetterCount", answerWordTxt.Text.Length);
                    command.Parameters.AddWithValue("@isAskedBefore", false);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Question has been successfully added to the database!");
                    command = new MySqlCommand();
                    command.Connection = MainMenuForm.connection;

                    command.CommandText = "insert into answers(answerWord) values(@answerWord)";
                    command.Parameters.AddWithValue("@answerWord", answerWordTxt.Text.ToUpper(new CultureInfo("tr-TR", false)));
                    command.ExecuteNonQuery();
                    MessageBox.Show("The Word has been successfully added to the database!");
                    command = new MySqlCommand();
                    command.Connection = MainMenuForm.connection;
                    FillLists();
                    questionRichTxt.Text = string.Empty;
                    answerWordTxt.Text = string.Empty;
                }
                catch (Exception ee)
                {
                    MessageBox.Show("A problem has occurred while inserting data to database!" + Environment.NewLine + ee.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
        }

        private void deleteQuestionAnswerButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("YOU ARE ABOUT TO DELETE A QUESTION AND ITS ANSWER FROM THE DATABASE. ARE YOU SURE?", "BIG WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DeleteQuestionFromDatabase();
            }
        }

        private void questionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            correctWordsList.SelectedIndex = questionsList.SelectedIndex;
        }

        private void correctWordsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionsList.SelectedIndex = correctWordsList.SelectedIndex;
        }

        private void resetDatabaseIdSystem_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = MainMenuForm.connection;
            int rowAmount;
            command.CommandText = "select count(*) from questions";
            rowAmount = Convert.ToInt32(command.ExecuteScalar());
            if (rowAmount == 0)
            {
                command.CommandText = "alter table questions auto_increment=1";
                command.ExecuteNonQuery();
                command = new MySqlCommand();
                command.Connection = MainMenuForm.connection;
            }
            else
            {
                MessageBox.Show("Databases are not empty. Process aborted!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            command.CommandText = "select count(*) from answers";
            rowAmount = Convert.ToInt32(command.ExecuteScalar());
            if (rowAmount == 0)
            {
                command.CommandText = "alter table answers auto_increment=1";
                command.ExecuteNonQuery();
                command = new MySqlCommand();
                command.Connection = MainMenuForm.connection;
            }
            else
            {
                MessageBox.Show("Databases are not empty. Process aborted!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void QuestionsManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm.mainMenuForm.WindowState = FormWindowState.Normal;
        }
    }
}
