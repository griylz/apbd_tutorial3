namespace ConsoleApp1.Exceptions;

public class OverFillException : Exception
{
    public OverFillException()
    {
    }

    public OverFillException(string? message) : base(message)
    {
        Console.WriteLine(message.Length);
    }

    public OverFillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}