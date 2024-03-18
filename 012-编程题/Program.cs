//输入一个三位数，倒叙输出
//Console.WriteLine("输入一个三位数。");
//int 数 = Convert.ToInt32(Console.ReadLine());
//int 个位 = 数 % 10;
//int 十位 = (数 / 10) % 10;
//int 百位 = 数 / 100;
//int 倒叙整数 = 个位 * 100 + 十位 * 10 + 百位;
//Console.WriteLine("这个数{0}的倒叙整数是{1}", 数,倒叙整数);

//分析一串数字，提取其中的千位和十位，然后找到对应数字的clss编码
//Console.WriteLine("请输入一串数字。");
//int 数字 = Convert.ToInt32(Console.ReadLine());
//int 十位 = (数字 / 10) % 10;
//int 千位 = (数字 / 1000) % 10;
//int 整数 = 千位 * 10 + 十位;
//char 结果 = (char)整数;
//Console.WriteLine("这个加密字符是{0}", 结果);

//int a = 3;
//int b = a++ + (++a);
//Console.WriteLine(b);

//输入数学和英语的分数，只有都考到90分才能获得奖励
Console.WriteLine("请输入数学的分数");
int 数学分数 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("请输入英语的分数");
int 英语分数 = Convert.ToInt32(Console.ReadLine());
if(数学分数>=90&&英语分数>=90)
{
    Console.WriteLine("你的成绩合格了，去领奖吧！");
}
else
{
    Console.WriteLine("你的成绩不合格，去挨罚吧");
}