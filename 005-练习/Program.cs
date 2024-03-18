//练习题一：让用户输入两个整数，计算两个整数的和，并输出出来。
//Console.WriteLine("请输入第一个整数！");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("请输入第二个整数！");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("现在输出这两个整数\n第一个整数是" + a + "\n第二个整数是" + b + "\n它们两个的和是" + (a + b));

//练习题二：让用户输入两个整数，计算这两个整数的平均数，并输出出来。
//Console.WriteLine("请输入第一个整数！");
//int 第一个整数 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("请输入第二个整数！");
//int 第二个整数 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("现在输出这两个整数\n第一个整数是" + 第一个整数 + "\n第二个整数是" + 第二个整数 + "\n它们两个的平均数是" + ((第一个整数 + 第二个整数) / 2));

//练习题三：将a元钱分给b个人，每个人可以分得多少，a、b都是整数
Console.WriteLine("请输入一共有多少钱");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("请输入一共有多少人");
int b = Convert.ToInt32(Console.ReadLine());
double 每个人平均分得多少钱 = a / b;
Console.WriteLine("每个人都能得到" + 每个人平均分得多少钱);