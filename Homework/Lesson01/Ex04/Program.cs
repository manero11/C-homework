System.Console.Write("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int value3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (value1 > value2) max = value1;
if (value2 > value3) max = value2;
if ((value3 > value1) && (value3 > value2)) max = value3;

System.Console.WriteLine("max = " + max);
