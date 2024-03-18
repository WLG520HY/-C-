//一个游乐场只有不大于16岁的才能进入
//Console.WriteLine("请输入你的年龄");
//int 年龄 = Convert.ToInt32(Console.ReadLine());
//if(年龄<=16)
//{
//    Console.WriteLine("符合条件，进去玩吧");
//}
//else
//{
//    Console.WriteLine("不符合条件，一边呆着去");
//}

//输入一个整数，判断是奇数还是偶数
//Console.WriteLine("请输入一个数字");
//int 数字 = Convert.ToInt32(Console.ReadLine());
//if(数字%2==0)
//{
//    Console.WriteLine("这个数字是偶数。");
//}
//else
//{
//    Console.WriteLine("这个数字是奇数。");
//}

//有一个活动，年龄在18-30岁才能参加，但是奇数年龄才能获得奖励
//Console.WriteLine("请输入参与者的年龄。");
//int 年龄 = Convert.ToInt32(Console.ReadLine());
//if (年龄 >= 18 && 年龄 <= 30)
//{
//    if (年龄 % 2 != 0)
//    {
//        Console.WriteLine("恭喜！你符合参加条件并获得了奖励！");
//    }
//    else
//    {
//        Console.WriteLine("很抱歉，你参加了活动但是没获得奖励。期待你的下次参与");
//    }
//}
//else
//{
//    Console.WriteLine("很抱歉，你并不符合这个活动的条件，不能参加。");
//}

//输入考试成绩（0-100）
//如果90-100，评级为A
//如果70-89，评级为B
//如果60-69，评级为C
//如果小于60，评级为D
//根据输入的成绩，输出评级
//Console.WriteLine("请输入你的考试成绩。");
//int 成绩 = Convert.ToInt32(Console.ReadLine());
//if (成绩 >= 90 && 成绩 <= 100)
//{
//    Console.WriteLine("你的成绩评级为A！");
//}
//else if (成绩 >= 70 && 成绩 <= 89)
//{
//    Console.WriteLine("你的成绩评级为B！");
//}
//else if (成绩 >= 60 && 成绩 <= 69)
//{
//    Console.WriteLine("你的成绩评级为C！");
//}
//else if (成绩 < 60)
//{
//    Console.WriteLine("你的成绩评级为D!");
//}

//输入平面直角坐标系中的一个坐标值，判断这个点是位于哪一个象限，原点或坐标轴上。
//Console.WriteLine("请输入坐标系中X的坐标。");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("请输入坐标系中Y的坐标。");
//int y = Convert.ToInt32(Console.ReadLine());
//if (x>0&&y>0)
//{
//    Console.WriteLine("这个点位于第一象限。");
//}
//else if(x<0&&y>0)
//{
//    Console.WriteLine("这个点位于第二象限。");
//}
//else if(x<0&&y<0)
//{
//    Console.WriteLine("这个点位于第三象限。");
//}
//else if(x>0&&y<0)
//{
//    Console.WriteLine("这个点位于第四象限。");
//}
//else if(x==0&&y==0)
//{
//    Console.WriteLine("这个点是原点。");
//}
//else if(x!=0&&y==0)
//{
//    Console.WriteLine("这个点在X轴上。");
//}
//else if(x==0&&y!=0)
//{
//    Console.WriteLine("这个点在Y轴上。");
//}

//输入三角形的三条边A,B,C判断是否可以组成三角形。
//Console.WriteLine("请输入A的边长。");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("请输入B的边长。");
//int b = Convert.ToInt32(Console.ReadLine));
//Console.WriteLine("请输入C的边长");
//int c = Convert.ToInt32(Console.ReadLine());
//if(a+b>c&&a+c>b&&b+c>a)
//{
//    if(c-b<a&&c-a<b&&a-b<c)
//    {
//        Console.WriteLine("这三条边能组成一个三角形。");
//    }
//}
//else
//{
//    Console.WriteLine("这三条边不能组成一个三角形。");
//}

//输入一个年份，判断该年是不是闰年。
//Console.WriteLine("请输入一个年份。");
//int 年份 = Convert.ToInt32(Console.ReadLine());
//if ((年份 % 4 == 0&&年份%100!=0)||年份%400==0)
//{
//    Console.WriteLine("是闰年。");
//}
//else
//{
//    Console.WriteLine("不是闰年。");
//} 

//输入一个整数，判断是正数还是负数，并输出它的绝对值
//Console.WriteLine("请输入一个非零整数。");
//int 数 = Convert.ToInt32(Console.ReadLine());
//if(数>0)
//{
//    Console.WriteLine("这是一个正数，它的绝对值是{0}", 数);
//}
//else if(数<0)
//{
//    Console.WriteLine("这是一个负数，它的绝对值是" + (数 * -1));
//}

//输入三个整数，求这三个整数中最大值的平方
//Console.WriteLine("依次输入三个整数。");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//if (a > b && a > c)
//{
//    Console.WriteLine(a * a);
//}
//else if (b > a && b > c)
//{
//    Console.WriteLine(b * b);
//}
//else if (c > a && c > b)
//{
//    Console.WriteLine(c * c);
//}
//第二种写法
//int max=a;
//if(b>max)
//{
//    max = b;
//}
//else if(c>max)
//{
//    max = c;
//}
//Console.WriteLine("{0}这个数最大的平方是{1}。", max, max * max);

//给出任意的大写字母，比较他们的大小，规定A、B、C……Z依次从小到大
//Console.WriteLine("随便输入两个大写字母。");
//char a = Convert.ToChar(Console.ReadLine());
//char b = Convert.ToChar(Console.ReadLine());
//int a1 = (int)a;
//int b1 = (int)b;
//if(a1>b1)
//{
//    Console.WriteLine("{0}字母<{1}字母", b, a);
//}
//else if(b1>a1)
//{
//    Console.WriteLine("{0}字母<{1}字母", a, b);
//}

//输入性别和号码
//男、长跑1000米、单数跳远、双数俯卧撑
//女、长跑800米、单数跳绳、双数仰卧起坐
//Console.WriteLine("请输入你的性别。");
//char 性别 = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("请输入你抽到的号码。");
//int 号码 = Convert.ToInt32(Console.ReadLine());
//if(性别=='男')
//{
//    if(号码%2==0)
//    {
//        Console.WriteLine("这位同学，你参加的项目是长跑1000米和俯卧撑。");
//    }
//    else if(号码%2!=0)
//    {
//        Console.WriteLine("这位同学，你参加的项目是长跑1000米和跳远。");
//    }
//}
//else if(性别=='女')
//{
//    if(号码%2==0)
//    {
//        Console.WriteLine("这位同学，你参加的项目是长跑800米和仰卧起坐。");
//    }
//    else if(号码%2!=0)
//    {
//        Console.WriteLine("这位同学，你参加的项目是长跑800米和跳绳。");
//    }
//}

//排序，输入三个整数，把这三个整数从小到大排序后输出
Console.WriteLine("输入第一个整数。");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("输入第二个整数。");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("输入第三个整数。");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b&&a>c)
{
    if (b>c)
    {
        Console.WriteLine("{0}<{1}<{2}", c, b, a);
    }
    else if(c>b)
    {
        Console.WriteLine("{0}<{1}<{2}", b, c, a);
    }
}
else if(b>a&&b>c)
{
    if(a>c)
    {
        Console.WriteLine("{0}<{1}<{2}", c, a, b);
    }
    else if(c>a)
    {
        Console.WriteLine("{0}<{1}<{2}", a, c, b);
    }
}
else if(c>a&&c>b)
{
    if(a>b)
    {
        Console.WriteLine("{0}<{1}<{2}", b, a, c);
    }
    else if(b>a)
    {
        Console.WriteLine("{0}<{1}<{2}", a, b, c);
    }
}