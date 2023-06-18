/*ЗЗадача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int nedelja (string message)
{
    Console.Write(message);
    string znachenue = Console.ReadLine();
    int answer = Convert.ToInt32(znachenue);
    return answer;

}

bool nedeljaKonec (int denNedeliu)
{
    if (denNedeliu > 5)
    {
        return true;
    }

    return false;
}

bool proverkaDanux (int enNum)
{
    if (enNum > 0 && enNum <= 7)
    {
        return true;
    }
    Console.WriteLine ("Данные не относятся к дню недели");
    return false;
}

int enterNumber = nedelja("введите любое число дня недели от 1 до 7: ");
if (proverkaDanux(enterNumber))
{
    if (nedeljaKonec(enterNumber))
    {   
        Console.WriteLine("в этот день мы будем отдыхать");
    }
    else
    {
        Console.WriteLine("в этот день мы будем работать");
    }
}
