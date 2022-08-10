System.Console.Write("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (value1 > value2) max = value1;
else max = value2;

System.Console.WriteLine("max = " + max);