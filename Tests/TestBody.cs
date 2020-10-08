using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tests
{
    public partial class TestBody : Form
    {
        TestStart parent;
        string cntstring;

        object[,] questions;

        int score, question;
        int rightAnswer;
        int rows;

        RadioButton check;

        public TestBody()
        {
            InitializeComponent();
        }
        public TestBody(TestStart parent, string TestName, string connectionstring)
        {
            InitializeComponent();
            this.parent = parent;
            testNameLabel.Text = TestName;
            cntstring = connectionstring;
        }

        private void TestBody_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnt = new SqlConnection(cntstring))
            {
                cnt.Open();
                string cmd = $"SELECT question.Number, question.QuestionText," +
                    $"question.Var1, question.Var2, question.Var3, question.Answer FROM [dbo].[question], [dbo].[test] WHERE question.TestID = test.ID AND test.Name = '{testNameLabel.Text}';";
                SqlCommand command = new SqlCommand(cmd, cnt);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    int rows = 0;
                    while (reader.Read())
                    {
                        rows++;
                    }

                    questions = new object[rows, reader.FieldCount];
                }
                reader.Close();

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    rows = 0;
                    while (reader.Read())
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            questions[rows, i] = reader.GetValue(i);
                        }
                        rows++;
                    }
                }
                reader.Close();
                cnt.Close();
            }

            //
            question = 0;
            score = 0;

            NextQuestion();
        }

        private void NextQuestion()
        {
            questionNumberLabel.Text = $"Вопрос {question + 1}/{rows}";
            scoreLabel.Text = $"Баллы: {score}/{rows}";
            questionBox.Text = questions[question, 1].ToString();
            radioButton1.Text = questions[question, 2].ToString();
            radioButton2.Text = questions[question, 3].ToString();
            radioButton3.Text = questions[question, 4].ToString();

            if (!int.TryParse(questions[question, 5].ToString(), out rightAnswer))
            {
                MessageBox.Show("Критическая ошибка.");
                Environment.Exit(-1);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (question < rows-1)
            {
                if (check.Name.ToString().Contains(questions[question, 5].ToString()))
                {
                    score++;
                }
                question++;
                NextQuestion();
            } else
            {
                FinishTest(score);
            }
        }

        private void FinishTest(int Score)
        {
            MessageBox.Show($"Ваш счёт: {Score}");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check = (RadioButton)(sender);
        }

        private void TestBody_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
