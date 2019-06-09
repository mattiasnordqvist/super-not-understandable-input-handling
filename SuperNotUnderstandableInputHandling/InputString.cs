namespace SuperNotUnderstandableInputHandling
{
    public class InputString : InputParam<string>
    {
        public InputString(string name, string description)
            : base(name, description, x => x)
        {
        }
    }
}