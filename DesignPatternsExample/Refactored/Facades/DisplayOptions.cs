using System;
using System.Collections.Generic;
using Refactored.Commands;

namespace Refactored.Facades
{
    public class Choice
    {
        public Choice(int option, string text, ICommand command)
        {
            Option = option;
            Text = text;
            Command = command;
        }

        public string Text { get; set; }
        public int Option { get; set; }
        public ICommand Command { get; set; }
    }

    public class DisplayOptions
    {
        public DisplayOptions()
        {
            _choices = new List<Choice>();
        }

        readonly List<Choice> _choices;

        public void MakeChoice()
        {
            bool contCheckout = true;
            while (contCheckout)
            {
                Console.WriteLine("Pick option?");

                _choices.ForEach(c => Console.WriteLine("{0} : {1}", c.Option, c.Text));

                var option = Convert.ToInt16(Console.ReadLine());

                var command = _choices.Find(c => c.Option == option).Command;
                command.Execute();

                contCheckout = command.ShouldContinue();
            }
        }

        public void AddChoice(ICommand command)
        {
            _choices.Add(new Choice(_choices.Count + 1, command.GetText(), command));
        }
    }
}