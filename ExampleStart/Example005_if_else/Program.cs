Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Здорово были бояре!");
}
else
{
    Console.Write("Исенмесез, ");
    Console.WriteLine(username);
}