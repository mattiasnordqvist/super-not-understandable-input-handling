namespace SuperNotUnderstandableInputHandling
{
    public interface IInput
    {
        string Name { get; }

        TrySetResult<T> TrySet<T>(Param<T> param);
    }
}