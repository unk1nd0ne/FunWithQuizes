using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizes
{
    public abstract class Question
    {
        private int questionId { get; }
        private static int nextId = 1;
        public string Query;
        //public List<char> Answer;
        public Dictionary<char, string> Options;

        public Question()
        {
            questionId = nextId;
            nextId++;
        }

        public Question (string query, Dictionary<char, string> options) : this()
        {
            Query = query;
            //Answer = answer;
            Options = options;
        }
        public abstract bool AnswerQuestion();

        public override bool Equals(object obj)
        {
            return obj is Question question &&
                   questionId == question.questionId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(questionId);
        }

        public override string ToString()
        {
            return $"{questionId}";
        }
    }
}
