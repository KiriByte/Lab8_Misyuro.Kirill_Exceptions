namespace Lab8_Misyuro.Kirill_Exceptions;

public class CheckLoginPassword
{
    public static bool Check(string login, string password, string confirmPassword)
    {
        if (login.Length >= 20) throw new WrongLoginException("Login too long");
        if (login.Any(c => char.IsWhiteSpace(c)))
        {
            throw new WrongLoginException("Login have space");
        }

        if (password.Length >= 20) throw new WrongPasswordException("Password too long");
        if (password.Any(c => char.IsWhiteSpace(c)))
        {
            throw new WrongPasswordException("Password have space");
        }

        if (!password.Any(c => char.IsDigit(c)))
        {
            throw new WrongPasswordException("Password must have one digit");
        }

        if (password != confirmPassword)
        {
            throw new WrongPasswordException("Password and confirmation password are different");
        }

        return true;
    }
}