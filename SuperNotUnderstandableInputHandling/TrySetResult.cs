namespace SuperNotUnderstandableInputHandling
{
    public class TrySetResult<T>
    {
        public string Name { get; }
        public T Value { get; }
        public string Source { get; }

        public TrySetResult(string name, T value, string source)
        {
            Name = name;
            Value = value;
            Source = source;
        }
    }
}