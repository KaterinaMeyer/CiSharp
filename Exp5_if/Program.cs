﻿Console.WriteLine("Введите Ваше имя ");
string username = Console.ReadLine();
 if (username == "Маша")
{
    Console.WriteLine("Ура! Это же Маша! ");
}
else 
{
    Console.WriteLine($"Привет, ");
    Console.WriteLine(username);
}