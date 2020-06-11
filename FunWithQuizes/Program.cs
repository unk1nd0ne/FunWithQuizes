using System;
using System.Collections.Generic;

namespace FunWithQuizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz newQuiz = new Quiz();
           
         
            newQuiz.AddQuestions(new MultipleChoice("What is the name of the earth's sun?", 'B', new Dictionary<char, string> {['A'] = "Bruno", ['B'] = "Sol", ['C'] = "Althea", ['D'] = "Bob"}));
            newQuiz.AddQuestions(new TrueFalse("The sky is up.", true, new Dictionary<char, string> { ['T'] = "True", ['F'] = "False"}));
            newQuiz.AddQuestions(new Checkbox("Which of the below are phases of water.", new List<char> { 'A', 'B', 'D'}, new Dictionary<char, string> { ['A'] = "Liquid", ['B'] = "Solid", ['C'] = "Old", ['D'] = "Gas" }));

            newQuiz.RunQuiz();
        }
    }
}
