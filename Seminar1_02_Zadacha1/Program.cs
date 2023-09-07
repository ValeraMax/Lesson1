//на входе проверяем два числа и выявляем может ли одно из них являтся квадратом другого 
System.Console.WriteLine("Введите число А: ");
double numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
double numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB*numberB)
{
    System.Console.WriteLine("Число " + numberB + " является квадратом числа " + numberA);
}

if (numberB == numberA*numberA)
{
    System.Console.WriteLine("Число " + numberA + " является квадратом числа " + numberB);
}
else
{
    System.Console.WriteLine("Нет числа, которое было бы квадратом другого числа");
}