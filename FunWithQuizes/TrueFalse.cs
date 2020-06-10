using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizes
{
    public class TrueFalse : Question
    {
        public bool Answer;

        public TrueFalse(string query, bool answer, Dictionary<char, string> options) : base(query, options)
        {
            Answer = answer;
        }
        public override bool AnswerQuestion()
        {
            string input;
            char answerChar;
            bool guess;

            Console.Write("Answer: ");
            input = Console.ReadLine();
            answerChar = char.Parse(input);

            if (char.ToLower(answerChar) == 't')
            {
                guess = true;
            }
            else
            {
                guess = false;
            }
            if (guess == Answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
