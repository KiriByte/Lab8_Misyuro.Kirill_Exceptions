namespace Lab8_Misyuro.Kirill_Exceptions;

public class WrongPasswordException : Exception
{
    public WrongPasswordException()
    {
    }

    public WrongPasswordException(string message) : base(message)
    {
    }
}