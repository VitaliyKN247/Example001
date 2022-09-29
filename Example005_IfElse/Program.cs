Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "алена")
{
    Console.WriteLine("Ура, это же Алена!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username); 
}