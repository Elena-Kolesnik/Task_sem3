// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using static System.Console;
Clear();

string N = (ReadLine()); 



if ((N[0].ToString(),N[1].ToString()) == (N[4].ToString(),N[3].ToString()))
{
   WriteLine("Да"); 
}
else
{
    WriteLine("Нет");
}


