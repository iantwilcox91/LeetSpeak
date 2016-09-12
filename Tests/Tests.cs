using Xunit;

namespace LeetSpeak.Objects
{
   public class LeetSpeakTests
   {
     [Fact]
     public void TurnToLeet_TurnsToArrayThenBack_true()
     {
       LeetSpeak phrase = new LeetSpeak();
       string phra = "Don't you love these 'String' exercises? I do!";
       string newPhra = phrase.TurnToLeet(phra);
       string output = "D0n't y0u l0v3 th3z3 'String' 3x3rciz3z? 1 d0!";
       Assert.Equal( output, newPhra );
     }

     [Fact]
     public void TurnToLeet_TurnsEsTo3s_true()
     {
       LeetSpeak phrase = new LeetSpeak();
       string input = "Phrase";
       string newPhra = phrase.TurnToLeet(input);
       string output = "Phraz3";
       Assert.Equal( output, newPhra );
     }
     [Fact]
     public void TurnToLeet_TurnsosTo0s_true()
     {
       LeetSpeak phrase = new LeetSpeak();
       string input = "xoo";
       string newPhra = phrase.TurnToLeet(input);
       string output = "x00";
       Assert.Equal( output, newPhra );
     }

     [Fact]
     public void TurnToLeet_TurnsIsTo1s_true()
     {
       LeetSpeak phrase = new LeetSpeak();
       string input = "Indiana";
       string newPhra = phrase.TurnToLeet(input);
       string output = "1ndiana";
       Assert.Equal( output, newPhra );
     }
     [Fact]
     public void TurnToLeet_TurnsSsToZs_true()
     {
       LeetSpeak phrase = new LeetSpeak();
       string input = "This has styles";
       string newPhra = phrase.TurnToLeet(input);
       string output = "Thiz haz styl3z";
       Assert.Equal( output, newPhra );
     }
   }
}
