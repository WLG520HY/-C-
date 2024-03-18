//输入四个整数，找出最大值和最小值
//Console.WriteLine("输入第一个整数。");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入第二个整数。");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入第三个整数。");
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入第四个整数。");
//int d = Convert.ToInt32(Console.ReadLine());
//int max = a, min = a;//定义一个最大变量和最小变量，先默认a是最大值同时也是最小值
//if(max<b)//假设最大值小于b
//{
//    max = b;//那就把b的值放进最大值里面
//}
//if(max<c)//假设最大值小于c
//{
//    max = c;//那就把c的值放进最大值里面
//}
//if(max<d)//假设最大值小于d
//{
//    max = d;//那就把d的值放进最大值里面
//}
//if(min>b)
//{
//    min = b;
//}
//if(min>c)
//{
//    min = c;
//}
//if(min>d)
//{
//    min = d;
//}
//Console.WriteLine("最大值是{0}，最小值是{1}。", max, min);

//输入两个整数，然后再输入0~3之间的一个数，0代表加法，1代表减法，2代表乘法，3代表除法，计算这两个数的结果
Console.WriteLine("输入第一个整数。");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("输入第二个整数。");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("输入运算符，0是加法，1是减法，2是乘法，3是除法。");
int c = Convert.ToInt32(Console.ReadLine());
switch(c)
{
    case 0:Console.WriteLine(a + b);break;
    case 1:Console.WriteLine(a - b);break;
    case 2:Console.WriteLine(a * b);break;
    case 3:Console.WriteLine(a / b);break;
    default:Console.WriteLine("请输入规定运算符代表的数字！");break;
}