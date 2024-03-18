//输入三个整数，把这三个数，从小到大排序后输出
//Console.WriteLine("输入第一个数。");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入第二个数。");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入第三个数。");
//int c = Convert.ToInt32(Console.ReadLine());
//if (a>b)
//{
//    int tmp = a;
//    a = b;
//    b = tmp;
//}
//else if(b>c)
//{
//    int tmp = b;
//    b = c;
//    c = tmp;
//}
//if (a>b)
//{
//    int tmp = a;
//    a = b;
//    b = tmp;
//}
//Console.WriteLine("{0}<{1}<{2}", a, b, c);

//输入一个小数m和整数k（k只能是0或者1）
//如果k是0，那么输出m的整数，
//如果k是1，那么输出m，保留一位小数
Console.WriteLine("输入小数。");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("输入零或者一。");
int k = Convert.ToInt32(Console.ReadLine());
if(k==0)
{
    int m1 = (int)m;
    m = m1;
}
else if(k==1)
{
    double m1 = ((int)((m+0.05)*10))/10;
    m = m1;
}
Console.WriteLine(m);