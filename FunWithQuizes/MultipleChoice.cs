using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizes
{
    public class MultipleChoice : Question
    {
        public char Answer;

        public MultipleChoice (string query, char answer, Dictionary<char, string> options) : base(query, options)
        {
            Answer = answer;
            Options = options;
        }

        public override bool AnswerQuestion()
        {
            string input;
            char answerChar;

            Console.Write("Answer: ");
            input = Console.ReadLine();
            answerChar = char.Parse(input);

            if (char.ToLower(answerChar) == char.ToLower(Answer))
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
