using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tietovisa
{
    public partial class QuizMultipleChoice : Form
    {
        private readonly QuizInfo _quizInfo;
        List<Result> questions = new();
        public QuizMultipleChoice(QuizInfo quizInfo, int questionCount)
        {
            InitializeComponent();
            _quizInfo = quizInfo;



            foreach (var question in quizInfo.results)
            {
                questions.Add(question);
            }

        }
    }
}
