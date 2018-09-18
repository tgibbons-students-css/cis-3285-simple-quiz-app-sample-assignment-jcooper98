using System;

namespace SimpleQuizApp
{
    public class MultipleChoiceQuestion : Question
    {
        String[] possibleAnswers;
        int answerIndex;

        public MultipleChoiceQuestion(String questionText, String[] possibleAnswers, int answerIndex) : base(questionText)
        {

            this.possibleAnswers = possibleAnswers;
            this.answerIndex = answerIndex;
        }
        public override string getAnswer()
        {
            return possibleAnswers[answerIndex];
        }

        public override bool checkAnswer(string answer)
        {
            return (answer.Equals(possibleAnswers[answerIndex]));
        }


        /**
         * getQuestion()
         * @return Adds newline after each possible answer
         */

        public override String getQuestion()
        {
            String fullQuestion = questionText + "\r\n";
            foreach (String s in possibleAnswers)
            {
                fullQuestion += s + "\r\n";
            }
            return fullQuestion;
        }
    }
}
