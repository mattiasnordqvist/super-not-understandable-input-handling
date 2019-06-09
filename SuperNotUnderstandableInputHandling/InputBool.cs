namespace SuperNotUnderstandableInputHandling
{
    public class InputBool : InputParam<bool>
    {
        public InputBool(string name, string description)
            : base(name, description, x =>
            {
                return bool.Parse(x);
            })
        {
        }
    }
}