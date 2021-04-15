
namespace WordGame
{
    partial class QuestionsManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsManagementForm));
            this.questionsList = new System.Windows.Forms.ListBox();
            this.questionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wordgamedatabaseDataSet = new WordGame.wordgamedatabaseDataSet();
            this.correctWordsList = new System.Windows.Forms.ListBox();
            this.answersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wordgamedatabaseDataSet1 = new WordGame.wordgamedatabaseDataSet1();
            this.getListItemsButton = new System.Windows.Forms.Button();
            this.questionRichTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.answerWordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addToDatabaseButton = new System.Windows.Forms.Button();
            this.questionsTableAdapter = new WordGame.wordgamedatabaseDataSetTableAdapters.questionsTableAdapter();
            this.answersTableAdapter = new WordGame.wordgamedatabaseDataSet1TableAdapters.answersTableAdapter();
            this.deleteQuestionAnswerButton = new System.Windows.Forms.Button();
            this.resetDatabaseIdSystem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordgamedatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordgamedatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsList
            // 
            this.questionsList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.questionsList.DataSource = this.questionsBindingSource1;
            this.questionsList.DisplayMember = "question";
            this.questionsList.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionsList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.questionsList.FormattingEnabled = true;
            this.questionsList.ItemHeight = 15;
            this.questionsList.Location = new System.Drawing.Point(21, 66);
            this.questionsList.Name = "questionsList";
            this.questionsList.Size = new System.Drawing.Size(600, 229);
            this.questionsList.TabIndex = 0;
            this.questionsList.SelectedIndexChanged += new System.EventHandler(this.questionsList_SelectedIndexChanged);
            // 
            // questionsBindingSource1
            // 
            this.questionsBindingSource1.DataMember = "questions";
            this.questionsBindingSource1.DataSource = this.wordgamedatabaseDataSet;
            // 
            // wordgamedatabaseDataSet
            // 
            this.wordgamedatabaseDataSet.DataSetName = "wordgamedatabaseDataSet";
            this.wordgamedatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // correctWordsList
            // 
            this.correctWordsList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.correctWordsList.DataSource = this.answersBindingSource1;
            this.correctWordsList.DisplayMember = "answerWord";
            this.correctWordsList.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctWordsList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.correctWordsList.FormattingEnabled = true;
            this.correctWordsList.ItemHeight = 15;
            this.correctWordsList.Location = new System.Drawing.Point(632, 66);
            this.correctWordsList.Name = "correctWordsList";
            this.correctWordsList.Size = new System.Drawing.Size(156, 229);
            this.correctWordsList.TabIndex = 1;
            this.correctWordsList.SelectedIndexChanged += new System.EventHandler(this.correctWordsList_SelectedIndexChanged);
            // 
            // answersBindingSource1
            // 
            this.answersBindingSource1.DataMember = "answers";
            this.answersBindingSource1.DataSource = this.wordgamedatabaseDataSet1;
            // 
            // wordgamedatabaseDataSet1
            // 
            this.wordgamedatabaseDataSet1.DataSetName = "wordgamedatabaseDataSet1";
            this.wordgamedatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getListItemsButton
            // 
            this.getListItemsButton.BackColor = System.Drawing.Color.DarkGray;
            this.getListItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getListItemsButton.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getListItemsButton.Location = new System.Drawing.Point(251, 12);
            this.getListItemsButton.Name = "getListItemsButton";
            this.getListItemsButton.Size = new System.Drawing.Size(308, 32);
            this.getListItemsButton.TabIndex = 2;
            this.getListItemsButton.Text = "Get the Questions and Words from Database";
            this.getListItemsButton.UseVisualStyleBackColor = false;
            this.getListItemsButton.Click += new System.EventHandler(this.getListItemsButton_Click);
            // 
            // questionRichTxt
            // 
            this.questionRichTxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.questionRichTxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionRichTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.questionRichTxt.Location = new System.Drawing.Point(21, 315);
            this.questionRichTxt.Name = "questionRichTxt";
            this.questionRichTxt.Size = new System.Drawing.Size(293, 99);
            this.questionRichTxt.TabIndex = 3;
            this.questionRichTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(248, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Questions List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(671, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Words List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(137, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Question";
            // 
            // answerWordTxt
            // 
            this.answerWordTxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerWordTxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerWordTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.answerWordTxt.Location = new System.Drawing.Point(350, 316);
            this.answerWordTxt.Name = "answerWordTxt";
            this.answerWordTxt.Size = new System.Drawing.Size(144, 22);
            this.answerWordTxt.TabIndex = 7;
            this.answerWordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(320, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "And";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(368, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correct Answer";
            // 
            // addToDatabaseButton
            // 
            this.addToDatabaseButton.BackColor = System.Drawing.Color.DarkGray;
            this.addToDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToDatabaseButton.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToDatabaseButton.Location = new System.Drawing.Point(349, 342);
            this.addToDatabaseButton.Name = "addToDatabaseButton";
            this.addToDatabaseButton.Size = new System.Drawing.Size(145, 48);
            this.addToDatabaseButton.TabIndex = 10;
            this.addToDatabaseButton.Text = "Add To Database";
            this.addToDatabaseButton.UseVisualStyleBackColor = false;
            this.addToDatabaseButton.Click += new System.EventHandler(this.addToDatabaseButton_Click);
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // answersTableAdapter
            // 
            this.answersTableAdapter.ClearBeforeFill = true;
            // 
            // deleteQuestionAnswerButton
            // 
            this.deleteQuestionAnswerButton.BackColor = System.Drawing.Color.DarkGray;
            this.deleteQuestionAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteQuestionAnswerButton.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuestionAnswerButton.Location = new System.Drawing.Point(632, 299);
            this.deleteQuestionAnswerButton.Name = "deleteQuestionAnswerButton";
            this.deleteQuestionAnswerButton.Size = new System.Drawing.Size(156, 46);
            this.deleteQuestionAnswerButton.TabIndex = 11;
            this.deleteQuestionAnswerButton.Text = "Delete Question and Answer";
            this.deleteQuestionAnswerButton.UseVisualStyleBackColor = false;
            this.deleteQuestionAnswerButton.Click += new System.EventHandler(this.deleteQuestionAnswerButton_Click);
            // 
            // resetDatabaseIdSystem
            // 
            this.resetDatabaseIdSystem.BackColor = System.Drawing.Color.DarkGray;
            this.resetDatabaseIdSystem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetDatabaseIdSystem.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDatabaseIdSystem.Location = new System.Drawing.Point(581, 414);
            this.resetDatabaseIdSystem.Name = "resetDatabaseIdSystem";
            this.resetDatabaseIdSystem.Size = new System.Drawing.Size(207, 24);
            this.resetDatabaseIdSystem.TabIndex = 12;
            this.resetDatabaseIdSystem.Text = "Reset Database ID System";
            this.resetDatabaseIdSystem.UseVisualStyleBackColor = false;
            this.resetDatabaseIdSystem.Click += new System.EventHandler(this.resetDatabaseIdSystem_Click);
            // 
            // QuestionsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetDatabaseIdSystem);
            this.Controls.Add(this.deleteQuestionAnswerButton);
            this.Controls.Add(this.addToDatabaseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.answerWordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionRichTxt);
            this.Controls.Add(this.getListItemsButton);
            this.Controls.Add(this.correctWordsList);
            this.Controls.Add(this.questionsList);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Game - Questions and Words Management Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestionsManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.QuestionsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordgamedatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordgamedatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox questionsList;
        private System.Windows.Forms.ListBox correctWordsList;
        private System.Windows.Forms.Button getListItemsButton;
        private System.Windows.Forms.RichTextBox questionRichTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox answerWordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addToDatabaseButton;
        private wordgamedatabaseDataSet wordgamedatabaseDataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource1;
        private wordgamedatabaseDataSetTableAdapters.questionsTableAdapter questionsTableAdapter;
        private wordgamedatabaseDataSet1 wordgamedatabaseDataSet1;
        private System.Windows.Forms.BindingSource answersBindingSource1;
        private wordgamedatabaseDataSet1TableAdapters.answersTableAdapter answersTableAdapter;
        private System.Windows.Forms.Button deleteQuestionAnswerButton;
        private System.Windows.Forms.Button resetDatabaseIdSystem;
    }
}