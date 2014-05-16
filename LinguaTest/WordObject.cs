using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinguaTest
{
    public class WordObject
    {
        public enum PartOfSpeechKind
        {
            Noun, Verb, Adjective,
            Article, Pronoun, Numeral,
            Adverb, Preposition,
            Conjunction, Interjection
        }

        public string Word { get; set; }
        public string Translate { get; set; }
        public PartOfSpeechKind PartOfSpeech { get; set; }

        public WordObject(string w, string t, PartOfSpeechKind pof)
        {
            Word = w;
            Translate = t;
            PartOfSpeech = pof;
        }
        public WordObject() { }

        public static PartOfSpeechKind GetPartOfSpeech(string str)
        {
            switch (str)
            {
                case "Существительное": return WordObject.PartOfSpeechKind.Noun;
                case "Прилагательное": return WordObject.PartOfSpeechKind.Adjective;
                case "Глагол": return WordObject.PartOfSpeechKind.Verb;
                case "Артикль": return WordObject.PartOfSpeechKind.Article;
                case "Местоимение": return WordObject.PartOfSpeechKind.Pronoun;
                case "Числительное": return WordObject.PartOfSpeechKind.Numeral;
                case "Наречие": return WordObject.PartOfSpeechKind.Adverb;
                case "Предлог": return WordObject.PartOfSpeechKind.Preposition;
                case "Союз": return WordObject.PartOfSpeechKind.Conjunction;
                case "Междометие": return WordObject.PartOfSpeechKind.Interjection;
                default: return PartOfSpeechKind.Interjection;
            }
        }

        public static string GetPartOfSpeechString(WordObject.PartOfSpeechKind pof)
        {
            switch (pof)
            {
                case WordObject.PartOfSpeechKind.Noun: return "Существительное";
                case WordObject.PartOfSpeechKind.Verb: return "Глагол";
                case WordObject.PartOfSpeechKind.Adjective: return "Прилагательное";
                case WordObject.PartOfSpeechKind.Article: return "Артикль";
                case WordObject.PartOfSpeechKind.Pronoun: return "Местоимение";
                case WordObject.PartOfSpeechKind.Numeral: return "Числительное";
                case WordObject.PartOfSpeechKind.Adverb: return "Наречие";
                case WordObject.PartOfSpeechKind.Preposition: return "Предлог";
                case WordObject.PartOfSpeechKind.Conjunction: return "Союз";
                case WordObject.PartOfSpeechKind.Interjection: return "Междометие";
                default: return "Неизвестное";
            }
        }
    }
}
