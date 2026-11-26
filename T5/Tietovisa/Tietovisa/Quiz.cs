using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tietovisa
{
    public partial class Quiz : Form
    {
        private readonly QuizInfo _quizInfo;
        public Quiz(QuizInfo quizInfo, int questionCount)
        {
            InitializeComponent();
            _quizInfo = quizInfo;

        }
    }
}
