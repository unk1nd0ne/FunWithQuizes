using System;
using System.Collections.Generic;

namespace FunWithQuizes
{
    class Quiz
    {
        static void Main(string[] args)
        {
            List<Question> FunQuiz = new List<Question>();
            int correct = 0;
         
            FunQuiz.Add(new MultipleChoice("What is the name of the earth's sun?", 'B', new Dictionary<char, string> {['A'] = "Bruno", ['B'] = "Sol", ['C'] = "Althea", ['D'] = "Bob"}));
            FunQuiz.Add(new TrueFalse("The sky is up.", true, new Dictionary<char, string> { ['T'] = "True", ['F'] = "False"}));
            FunQuiz.Add(new Checkbox("Which of the below are phases of water.", new List<char> { 'A', 'B', 'D'}, new Dictionary<char, string> { ['A'] = "Liquid", ['B'] = "Solid", ['C'] = "Old", ['D'] = "Gas" }));


            foreach (Question item in FunQuiz)
            {
                Console.WriteLine(item.Query);
                foreach(char key in item.Options.Keys)
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
                Console.WriteLine($"You got {correct} out of {FunQuiz.Count} correct!");
            }
        }
    }
}
