using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinguaTest {
    public class WordObject {
        public enum PartOfSpeechKind {
            Noun, Verb, Adjective,
            Article, Pronoun, Numeral,
            Adverb, Preposition,
            Conjunction, Interjection,
            Unknown
        }

        public string Word { get; set; }
        public string Translate { get; set; }
        public PartOfSpeechKind PartOfSpeech { get; set; }

        public WordObject(string w, string t, PartOfSpeechKind pof) {
            Word = w;
            Translate = t;
            PartOfSpeech = pof;
        }
        public WordObject() { }

        public static PartOfSpeechKind GetPartOfSpeech(string str) {
            switch (str) {
                case "Существительное":
                case "Noun": return WordObject.PartOfSpeechKind.Noun;
                case "Прилагательное":
                case "Adjective": return WordObject.PartOfSpeechKind.Adjective;
                case "Глагол":
                case "Verb": return WordObject.PartOfSpeechKind.Verb;
                case "Артикль":
                case "Article": return WordObject.PartOfSpeechKind.Article;
                case "Местоимение":
                case "Pronoun": return WordObject.PartOfSpeechKind.Pronoun;
                case "Числительное":
                case "Numeral": return WordObject.PartOfSpeechKind.Numeral;
                case "Наречие":
                case "Adverb": return WordObject.PartOfSpeechKind.Adverb;
                case "Предлог":
                case "Preposition": return WordObject.PartOfSpeechKind.Preposition;
                case "Союз":
                case "Conjunction": return WordObject.PartOfSpeechKind.Conjunction;
                case "Междометие":
                case "Interjection": return WordObject.PartOfSpeechKind.Interjection;
                default: return PartOfSpeechKind.Unknown;
            }
        }

        public static string GetPartOfSpeechString(WordObject.PartOfSpeechKind pof) {
            switch (pof) {
                case WordObject.PartOfSpeechKind.Noun: return "Noun";
                case WordObject.PartOfSpeechKind.Verb: return "Verb";
                case WordObject.PartOfSpeechKind.Adjective: return "Adjective";
                case WordObject.PartOfSpeechKind.Article: return "Article";
                case WordObject.PartOfSpeechKind.Pronoun: return "Pronoun";
                case WordObject.PartOfSpeechKind.Numeral: return "Numeral";
                case WordObject.PartOfSpeechKind.Adverb: return "Adverb";
                case WordObject.PartOfSpeechKind.Preposition: return "Preposition";
                case WordObject.PartOfSpeechKind.Conjunction: return "Conjunction";
                case WordObject.PartOfSpeechKind.Interjection: return "Interjection";
                default: return "Неизвестное";
            }
        }
    }
}