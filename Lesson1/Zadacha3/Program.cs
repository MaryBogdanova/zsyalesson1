Console.WriteLine("Введите положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 0)
{
    num1 = num1 * -1;
}
else 
{
    Console.WriteLine("Введено число 0");
}
int num2 = -num1;

while (num2 <= num1)
{
    Console.WriteLine(num2);
    num2 = num2 + 1;
}
