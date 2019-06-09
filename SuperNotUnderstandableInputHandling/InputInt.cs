namespace SuperNotUnderstandableInputHandling
{
    public class InputInt : InputParam<int>
    {
        public InputInt(string name, string description)
            : base(name, description, x => int.Parse(x))
        {
        }
    }
}