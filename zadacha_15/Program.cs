/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int numberAll (string message)
{
    Console.Write(message);
    string enternum = Console.ReadLine();
    int answer1 = Convert.ToInt32(enternum);
    return answer1;
}

int poluchitTretieChuslo (int num2)
{
    while (num2 > 999){
        num2 /= 10;
    }
    return num2 % 10;
}

bool proverkaNaKolichNumber (int num2){

    if (num2 < 100)
    {
        Console.WriteLine("Число меньше 100");
    }

    return true;
}

int num2 = numberAll("введите любое целое число: ");
if (proverkaNaKolichNumber(num2)){
    Console.WriteLine(poluchitTretieChuslo(num2));
}