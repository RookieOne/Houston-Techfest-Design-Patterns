using System;
using System.Collections.Generic;
using System.Linq;

namespace Original
{
    public class Choice
    {
        public int Num { get; set; }
        public string Text { get; set; }
        public ICommand Command { get; set; }

        public Choice(int num, string text, ICommand command)
        {
            Num = num;
            Text = text;
            Command = command;
        }
    }

    public class DisplayOptions
    {
        List<Choice> _choices;

        public DisplayOptions()
        {
            _choices = new List<Choice>();
        }

        public void MakeChoice()
        {
            bool contCheckout = true;
            while (contCheckout)
            {
                foreach (var choice in _choices)
                {
                    Console.WriteLine("{0} : {1}", choice.Num, choice.Text);
                }

                var option = Convert.ToInt16(Console.ReadLine());
                var command = _choices.First(c => c.Num == option).Command;
                command.Execute();
                contCheckout = command.ShouldContinue();
            }
        }
        
        public void AddChoice(Choice choice)
        {
            _choices.Add(choice);
        }

        public void AddChoice(string text, ICommand command)
        {
            var choice = new Choice(_choices.Count + 1, text, command);
            this.AddChoice(choice);
        }
    }
}