Console.WriteLine("Введите имя польлзователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Здорова, Маша!");
}
else
{
    Console.Write("Пошел к черту, " + username + "!");
    //Console.WriteLine(username + "!");
}