using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinguaTest
{
    class WordObject
    {
        public enum PartOfSpeechKind
        {
            Noun, Verb, Adjective,
            Article, Pronoun, Numeral,
            Adverb, Preposition,
            Conjuction
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
    }
}
