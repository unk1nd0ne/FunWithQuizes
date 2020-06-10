using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizes
{
    public abstract class Question
    {
        public string Query;
        //public List<char> Answer;
        public Dictionary<char, string> Options;

        public Question (string query, Dictionary<char, string> options)
        {
            Query = query;
            //Answer = answer;
            Options = options;
        }
        public abstract bool AnswerQuestion();
    }
}
