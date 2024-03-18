//int a = 0;
//while(a<100)
//{
//    a++;
//    Console.WriteLine(a);
//}

//模拟第一个怪攻击的AI，玩家的血没到零就一直攻击。
//int HP = 100;
//while(0<HP)
//{
//    HP--;
//    if(HP==0)
//    {
//        Console.WriteLine("你的生命值为零，以死亡。");
//        break;
//    }
//    Console.WriteLine("你受到了攻击，当前生命值为{0}.", HP);
//}

//从大到小输出循环
//int i = 101;
//while(i>1)
//{
//    i--;
//    Console.WriteLine(i);
//}

//输入整数n，计算1+2+3+……+n的和。
//Console.WriteLine("随便输入一个整数。");
//int n = Convert.ToInt32(Console.ReadLine());
//int i = 1;
//int he = 0;
//while(i<=n)
//{
//    he += i;
//    i++;
//}
//Console.WriteLine(he);

//输出1~100之间的所有偶数。
//int i = 1;
//while(i<101)
//{
//    i++;
//    if(i%2==0)
//    {
//        Console.WriteLine(i);
//    }
//}

//输入n1和n2两个整数，输出n1到n2之间所有的偶数（包含n1和n2）
//Console.WriteLine("输入整数n1的值。");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入整数n2的值。");
//int n2 = Convert.ToInt32(Console.ReadLine());
//if(n1<n2)
//{
//    while(n1<=n2)
//    {
//        if(n1%2==0)
//        {
//            Console.WriteLine(n1);
//        }
//        n1++;
//    }
//}
//else if(n1>n2)
//{
//    while(n2<=n1)
//    {
//        if(n2%2==0)
//        {
//            Console.WriteLine(n2);
//        }
//        n2++;
//    }
//}

//3n+1,输入n，若n为奇数，则3n+1，否则变成n的一半
Console.WriteLine("输入一个自然整数。");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (n != 1)
{
    if (n % 2 != 0)
    {
        n = 3 * n + 1;
    }
    else if (n % 2 == 0)
    {
        n /= 2;
    }
    i++;
    Console.WriteLine("变换后的值是{0}。", n);
}
Console.WriteLine("一共变换了{0}次", i);