using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinguaTest {
    public class UserAnswer {
        public string Question { get; set; }
        public string Answer { get; set; } // User's answer
        public string RightAnswer { get; set; }

        public bool IsCorrect {
            get { return Answer == RightAnswer; }
        }

        public UserAnswer(string qs, string a, string ra) {
            Question = qs;
            Answer = a;
            RightAnswer = ra;
        }
        public UserAnswer() { }

        public string FormattedAnswer() {
            RichTextBox rtb = new RichTextBox();
            rtb.Text = Answer;
            rtb.Font = new Font("Segoe UI", 10);

            if (IsCorrect) {
                rtb.Select(0, Answer.Length);
                rtb.SelectionColor = Color.Green;
                rtb.SelectionAlignment = HorizontalAlignment.Center;
                rtb.DeselectAll();
                return rtb.Rtf;
            }

            rtb.Text += " " + RightAnswer;
            rtb.Select(0, Answer.Length);
            rtb.SelectionFont = new Font(rtb.SelectionFont, FontStyle.Strikeout);
            rtb.Select(Answer.Length + 1, RightAnswer.Length);
            rtb.SelectionColor = Color.Green;
            rtb.SelectAll();
            rtb.SelectionAlignment = HorizontalAlignment.Center;
            rtb.DeselectAll();

            return rtb.Rtf;
        }
    }
}