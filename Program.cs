namespace Lab8_Misyuro.Kirill_Exceptions;

class Program
{
    static void Main(string[] args)
    {
        var db = new UsersForTest();
        AddUsers(db);
        foreach (var user in db.usersList)
        {
            try
            {
                Console.Write($"{user.login,25}{user.password,25}{user.confirmPassword,25}");
                new CheckLoginPassword().Check(user.login, user.password, user.confirmPassword);
                Console.WriteLine("\tPASS");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t" + ex.Message);
            }
        }
    }

    static void AddUsers(UsersForTest db)
    {
        db.AddUser("rockstar4549rockstar4549", "c3KXazAKnWaq4V", "c3KXazAKnWaq4V");
        db.AddUser("worst", "VBDgZvJ4zw94BM", "VBDgZvJ4zw94BM");
        db.AddUser("economic8474", "HMYcqmUu93siiJHMYcqmUiJ", "HMYcqmUu93siiJ");
        db.AddUser("doormat1449", "6xZXK 9Q7T7hFDW", "6xZXK9Q7T7hFDW");
        db.AddUser("flavored3443", "UeEn3urvnmm6PC", "UeEn3urvnmm6PC");
        db.AddUser("gyration0715", "zaPrycGSghbC67", "VeUn2VCCvbL2ad");
        db.AddUser("enjoying6873", "VeUnVCCvbLad", "VeUnVCCvbLad");
        db.AddUser("sa vage1", "7SKhEmn9KmQrBj", "7SKhEmn9KmQrBj");
    }
}

class Login
{
    public string login;
    public string password;
    public string confirmPassword;

    public Login(string login, string password, string confirmPassword)
    {
        this.login = login;
        this.password = password;
        this.confirmPassword = confirmPassword;
    }
}

class UsersForTest
{
    public List<Login> usersList = new List<Login>();

    public void AddUser(string login, string password, string confirmPassword)
    {
        usersList.Add(new Login(login, password, confirmPassword));
    }
}