using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Trivia
    {
        public string question { get; set; }
        public string answer { get; set; }
        public Trivia(string Q, string A)
        {
            this.question = Q;
            this.answer = A;
        
        }
     
    }
}
