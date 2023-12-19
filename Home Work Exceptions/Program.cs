using Home_Work_Exceptions;

{
    string login = "toolongloginnamethatismorethan20characters";
    string password = "weakpassword";
    string confirmPassword = "mismatchedpassword";

    try
    {
        UserValidator.Validate(login, password, confirmPassword);
    }
    catch (WrongLoginException e)
    {
        Console.WriteLine("Wrong login: " + e.Message);
    }
    catch (WrongPasswordException e)
    {
        Console.WriteLine("Wrong password: " + e.Message);
    }
    Console.ReadKey();
}