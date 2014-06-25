using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinguaTest
{
    class UserAnswer
    {
        public string Question { get; set; }
        public string Answer { get; set; } // User's answer
        public string RightAnswer { get; set; }

        public static readonly UserAnswer DontKnow = new UserAnswer(null, null, null);

        public bool IsCorrect
        {
            get { return Answer == RightAnswer; }
        }

        public UserAnswer(string qs, string a, string ra)
        {
            Question = qs;
            Answer = a;
            RightAnswer = ra;
        }
        public UserAnswer() { }

        private string RepeatString(string str, int times)
        {
            string res = "";
            for (int i = 0; i < times; i++)
                res += str;
            return res;
        }

        public string FormattedAnswer()
        {
            RichTextBox rtb = new RichTextBox();
            rtb.Text = Answer;

            if (IsCorrect)
                return rtb.Rtf;

            rtb.Select(0, Answer.Length);
            rtb.SelectionFont = new Font(rtb.SelectionFont, FontStyle.Strikeout);
            rtb.Text += " " + RightAnswer;
            rtb.Select(Answer.Length + 1, RightAnswer.Length);
            rtb.SelectionColor = Color.Green;

            return rtb.Rtf;
        }
    }
}
