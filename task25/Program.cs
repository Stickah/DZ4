Console.WriteLine("введите два числа");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
if (B==0)
result = 1;
else{
for (int i=0;i<B-1;i++)
    result=result*A;
}
Console.WriteLine(result);