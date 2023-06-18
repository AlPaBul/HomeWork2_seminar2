// See https://aka.ms/new-console-template for more information
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/



void start(){
Console.Clear();
Console.WriteLine("введите любое целое трехзначное число: ");
}

start();


int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"вами было введено число {number1}");


int numberInCenter(int x){

    int rezultat = (x / 10) % 10;
    return rezultat;
}

int answerNumberInCenter = numberInCenter(number1);
Console.WriteLine($"в Вашем числе {number1} в центре {answerNumberInCenter}");


