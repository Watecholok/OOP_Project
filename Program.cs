// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {

        Welcome welcome = new Welcome();
        welcome.welcomeMessage();

        while (true)
        {
            Option option = new Option();
            option.optionMenu();
            char userOption = Convert.ToChar(Console.ReadLine());
        }
    }
}
