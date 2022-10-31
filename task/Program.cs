#region task1
//Verilmiş ədədin 2 -in neçənci qüvvəti(və ya neçənci qüvvətinə yaxın) olduğunu tapın

int num = 24, count = 0,number=0;
for (int i = 2; i <=num; i*=2)
{
    count++;
    number=i;
}
if ((num - number)<=(2*number-num))
{
    Console.WriteLine(count);
}
else if ((num - number) > (2 * number - num))
{
    count++;
    Console.WriteLine(count);
}

#endregion
#region task2
//Ədədin rəqəmləri cəmini tapın

int num1 = 123, sum = 0;
while (num1 != 0)
{
    sum += num1 % 10;
    num1 /= 10;
}
Console.WriteLine(sum);

#endregion
#region task3
//Daxil olunan müsbət tam ədədin sadə və ya mürəkkəb olduğunu tapın
int num2=17,test=0;
for(int i=2;i<num2;i++)
{
    if(num2%i==0)
    {
        test = 1;
        break;
    }
}
if(num2==1)
{
    Console.WriteLine("1 ne sadedir ne de murekkeb");
}
else if (test==1)
{
    Console.WriteLine("eded murekkebdir");

}
else if(test==0)
{
    Console.WriteLine("eded sadedir");
}
#endregion