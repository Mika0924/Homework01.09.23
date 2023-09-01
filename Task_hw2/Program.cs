
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int i = int.Parse(ReadInput);
    return i;
}
int General(int n)
{
    int i = 0;
    while (n > 0)
    {
        i += n % 10;
        n = n / 10;
    }
    return i;
}
int n = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {n} = {General(n)}");