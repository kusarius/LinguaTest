using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinguaTest
{
    class QuestionObject
    {
        public string FirstQuestionPart { get; set; }
        public string SecondQuestionPart { get; set; }

        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public string Variant3 { get; set; }
        public string Variant4 { get; set; }

        public int RightAnswerNumber { get; set; }

        public QuestionObject() { }
        public QuestionObject(string fqp, string sqp,
            string var1, string var2, 
            string var3, string var4,
            int ran)
        {
            FirstQuestionPart = fqp;
            SecondQuestionPart = sqp;
            Variant1 = var1;
            Variant2 = var2;
            Variant3 = var3;
            Variant4 = var4;
            RightAnswerNumber = ran;
        }
    }
}
