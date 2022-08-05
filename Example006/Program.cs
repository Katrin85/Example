Console.WriteLine ("Введите своё имя");
string username = Console.ReadLine ();
if (username.ToLower() == "катя")
{
   Console.WriteLine ("Ура, наша Катя заглянула!");
}
else if (username.ToLower() == "леня")
{
    Console.WriteLine ("Ооооо, Лёнчик давно тебя не было видно!");
}
else
{ 
   Console.WriteLine ("Привет, " + username);
   Console.WriteLine ("Сколько тебе лет?");
   string years = Console.ReadLine ();
   Console.WriteLine (username + ", ты уже большой(ая). Тебе  " + years + " лет"); 
   Console.WriteLine ("Будем знакомы!");
}