namespace Lab8_Misyuro.Kirill_Exceptions;

public class WrongLoginException : Exception
{
    public WrongLoginException()
    {
    }

    public WrongLoginException(string message) : base(message)
    {
    }
}