Console.WriteLine("введите количество цифр в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int [] mass = new int [N];
int i = 0;
while (i<N)
{mass [i] = new Random().Next(1,5000);
Console.Write($"{mass[i]} ");
i++;
};