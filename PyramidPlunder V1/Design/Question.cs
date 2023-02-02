using PyramidPlunder_V1.Design.Room_1;
using System;

namespace PyramidPlunder_V1.Design
{
    public class Question
    {
        public string Text { get; set; }
        public string UserAnswer { get; set; }

        private string _Answer;

        public Question(string text ,string answer)
        {
            Text = text;
            _Answer = answer;
        }

        public void Ask()
        {
            Console.WriteLine(Text);

            string answer = Console.ReadLine();

            UserAnswer = answer;
        }

        public void CheckAnswer()
        {
            if (UserAnswer.Trim().ToUpper() == _Answer.Trim().ToUpper())
                Console.WriteLine("You answered correctly. The stone door slides open allowing you to access the next room..");
            else
            {
                Console.WriteLine("Wrong answer! You triggered a booby trap and fell to your death.");

                throw new Exception("you're wrong ");
            }
        }
    }
}
