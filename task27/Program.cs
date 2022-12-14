Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
if (N>0)
{
while (N>=10)
{
Sum = Sum+(N%10);
N=N/10;
}
Sum = Sum+N;
}
Console.WriteLine(Sum);