using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithQuizes
{
    public class Quiz
    {
        private int quizId { get; }
        private static int nextId = 1;
        public List<Question> FunQuiz = new List<Question>();

        public Quiz ()
        {
            quizId = nextId;
            nextId++;
        }

        public void AddQuestions(Question query)
        {
            FunQuiz.Add(query);
        }

        public void RunQuiz ()
        {
            int correct = 0;

            foreach (Question item in FunQuiz)
            {
                Console.WriteLine(item.Query);
                foreach (char key in item.Options.Keys)
                {
                    Console.WriteLine($"{key}: {item.Options[key]}");
                }
                if (item.AnswerQuestion())
                {
                    Console.WriteLine("CORRECT!!!");
                    correct++;
                }
                else
                {
                    Console.WriteLine("INCORRECT!!!");
                }
            }
            Console.WriteLine($"You got {correct} out of {FunQuiz.Count} correct!");
        }
    }
}
