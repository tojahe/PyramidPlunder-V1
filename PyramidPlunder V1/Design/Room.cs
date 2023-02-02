using PyramidPlunder_V1.Design.Room_1;
using System;

namespace PyramidPlunder_V1.Design
{
    public abstract class Room
    {
        public abstract void Welcome();

        public Question Question { get; set; }

        public Room(Question question)
        {
            Question = question;
        }

        public void AskQuestion()
        {
            Question.Ask();
        }

        public void CheckAnswer()
        {
            Question.CheckAnswer();
        }
    }
}
