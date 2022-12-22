using System.Runtime.InteropServices;

namespace James_Webb_Lover.Models
{
    public class Trivia
    {
        public List<Trivia> FunFacts { get; set; }
        public int TriviaId { get; set; }

        public string TriviaName { get; set; }

        public Trivia(List<Trivia> funFacts, int triviaId, string triviaName)
        {
            FunFacts = funFacts;
            TriviaId = triviaId;
            TriviaName = triviaName;
        }

        public override bool Equals(object? obj)
        {
            return obj is Trivia trivia &&
                   EqualityComparer<List<Trivia>>.Default.Equals(FunFacts, trivia.FunFacts) &&
                   TriviaId == trivia.TriviaId &&
                   TriviaName == trivia.TriviaName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FunFacts, TriviaId, TriviaName);
    
        }

      /*  static public string GetFieldValue(Trivia TriviaName)
        {
            string theValue;
            if (TriviaName.Equals("Fun Fact"))
            {
               // theValue = TriviaData.FunFact;
            }
            else (TriviaName.Equals("Trivia"))
            {
                theValue = Trivia.ToString();
            }
           // return theValue;
        } */

    }

}
