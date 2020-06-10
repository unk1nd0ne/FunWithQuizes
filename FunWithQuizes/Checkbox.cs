using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizes
{
    public class Checkbox : Question
    {
        public List<char> Answer;

        public Checkbox(string query, List<char> answer, Dictionary<char, string> options) : base(query, options)
        {
            Answer = answer;
        }
        public override bool AnswerQuestion()
        {
            string input;
            char answerChar;
            List<char> guessList = new List<char>();
            int correct = 0;

            Console.Write("Answer enter letter to select, blank enter to move on: ");
            input = Console.ReadLine();
            while (input.Length > 0)
            {
                answerChar = char.Parse(input);
                guessList.Add(answerChar);
                Console.Write("Answer enter letter to select, blank enter to move on: ");
                input = Console.ReadLine();

            } 

            foreach (char guess in guessList)
            {
                if (Answer.Contains(char.ToUpper(guess)))
                {
                    correct++;
                }
            }

            if (correct == Answer.Count)
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
