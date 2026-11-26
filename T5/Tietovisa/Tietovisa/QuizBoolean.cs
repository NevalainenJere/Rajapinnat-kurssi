using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tietovisa
{
    public partial class QuizBoolean : Form
    {
        string correct = "correct";
        string incorrect = "incorrect";
        string correctAnswer;
        string userAnswer;
        int sustain = 0;

        public QuizBoolean(QuizInfo quizInfo, int questionCount)
        {
            InitializeComponent();

            userAnswer = "none";

            if (userAnswer == "none")
            {

            }
            else if (userAnswer != "none") 
            {
                for (int i = 0; i < questionCount; i++)
                {
                    var currentInfo = quizInfo.results[i];
                    string currentQuestion = quizInfo.results[i].question;
                    labelQuestion.Text = currentQuestion;
                    sustain = 0;

                    AnswerValidation(currentInfo, sustain);
                }
            }
            labelQuestion.Text = "Quiz finished.";
        }

        private async void AnswerValidation(Result currentInfo, int sustain)
        {
            await AwaitedValidation(currentInfo, sustain);
        }

        private async Task AwaitedValidation(Result currentInfo, int sustain)
        {
            while (sustain == 0)
            {
                if (currentInfo.correct_answer == "true")
                {
                    correctAnswer = "true";
                    if (correctAnswer == userAnswer)
                    {
                        labelQuestion.Text = "Correct :)";
                        await Task.Delay(1000);
                        sustain = 1;
                    }
                    else
                    {
                        labelQuestion.Text = "INCORRECT!!";
                        await Task.Delay(1000);
                        sustain = 1;
                    }
                }
                else if (currentInfo.correct_answer == "false")
                {
                    correctAnswer = "false";
                    if (correctAnswer == userAnswer)
                    {
                        labelQuestion.Text = "Correct :)";
                        await Task.Delay(1000);
                        sustain = 1;
                    }
                    else
                    {
                        labelQuestion.Text = "INCORRECT!!";
                        await Task.Delay(1000);
                        sustain = 1;
                    }
                }
                else continue;
            }
        }

        private async void buttonTrue_Click(object sender, EventArgs e)
        {
            userAnswer = "true";
        }

        private async void buttonFalse_Click(object sender, EventArgs e)
        {
            userAnswer = "false";
        }
    }
}
