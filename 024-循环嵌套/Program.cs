//输出十个*号。
//for(int i=1;i<=10;i++)
//{
//    Console.Write("*");
//}

//输出四行，每行十个*号。
//for(int i=1;i<=4;i++)
//{
//    for(int j=1;j<=10;j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//输入整数n和m，输出n行，每行m个*号。
//Console.WriteLine("请输入多少行。");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("请输入每行多少个。");
//int m = Convert.ToInt32(Console.ReadLine());
//for(int i=1;i<=n;i++)
//{
//    for(int j=1;j<=m;j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//输入整数n，输出n层的三角形。
//Console.WriteLine("输入任意整数。");
//int n = Convert.ToInt32(Console.ReadLine());
//for(int i=1;i<=n;i++)
//{
//    for(int j=1;j<=i;j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//输入整数n，输出n层的斜边。
Console.WriteLine("输入任意数。");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
    for(int j=1;j<=i-j;j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}