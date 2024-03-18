//for(int i=0;i<10;i++)
//{
//    Console.WriteLine(i);
//}

//for(int i=1;i<=10;i++)
//{
//    Console.WriteLine(i);
//}

//在同一行输出20个*号
//for(int i=0;i<20;i++)
//{
//    Console.Write(i+"*");
//}

//利用for循环计算1~100的和
//int 和 = 0;
//for(int i=1;i<101;i++)
//{
//    和 += i;
//}
//Console.WriteLine(和);

//利用for循环输出1~100之间所有的偶数
//for(int i=1;i<101;i++)
//{
//    if(i%2==0)
//    {
//        Console.WriteLine(i);
//    }
//}

//输入两个正整数n和m，计算n和m之间所有能被17整除的数的和。（包含n和m）
//Console.WriteLine("输入n的值。");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入m的值。");
//int m = Convert.ToInt32(Console.ReadLine());
//int 和 = 0;
//if(n<m)
//{
//    for(;n<=m;n++)
//    {
//        if(n%17==0)
//        {
//            和 += n;
//        }
//    }
//}
//else if(m<n)
//{
//    for(;m<=n;m++)
//    {
//        if(m%17==0)
//        {
//            和 += m;
//        }
//    }
//}
//Console.WriteLine(和);

//输入两个正整数n和m，利用for循环打印出来n和m之间，所有的奇数和所有的偶数，
//奇数放在一行用空格分割，偶数放在一行用空格分割。（包含n和m）
Console.WriteLine("输入n的值。");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("输入m的值。");
int m = Convert.ToInt32(Console.ReadLine());
string ji = " ";
string ow = " ";
if(n<m)
{
    for(;n<=m;n++)
    {
        if(n%2!=0)
        {
            ji += n+" ";
        }
        if (n % 2 == 0)
        {
            ow += n+" ";
        }
    }
}
else if(m<n)
{
    for(;m<=n;m++)
    {
        if(m%2==1)
        {
            ji += m+" ";
        }
        if(m%2==0)
        {
            ow += m+" ";
        }
    }
}
Console.Write(ji);
Console.WriteLine();
Console.Write(ow);