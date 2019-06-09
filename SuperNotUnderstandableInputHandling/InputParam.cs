using System;

namespace SuperNotUnderstandableInputHandling
{
    public class InputParam<T>
    {
        public Func<string, T> Parse;
        public string Name { get; }
        public string Description { get; }

        public InputParam(string name, string description, Func<string, T> parse)
        {
            Name = name;
            Description = description;
            Parse = parse;
        }
    }
}