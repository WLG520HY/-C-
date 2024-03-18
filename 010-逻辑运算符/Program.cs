//          &&这个是逻辑与
//          ||这个是逻辑或
//          !这个是逻辑非
//bool a = (3 < 4) && (9 < 10);//逻辑与：两边条件都满足的时候才返回ture
//Console.WriteLine(a);
//bool b = (3 < 4) || (9 > 10);//逻辑或：两边条件任意一边满足都返回ture
//Console.WriteLine(b);
//bool c = !(9 > 10);//逻辑非：返回与条件相反的判断
//Console.WriteLine(c);

//输入一个人的年龄，判断这个人是否是青年，青年的标准是18-60岁。
Console.WriteLine("请输入你的年龄。");
int sui = Convert.ToInt32(Console.ReadLine());
if (18 <= sui && sui <= 60)
{
    Console.WriteLine("你是青年。");
}
else
{
    Console.WriteLine("你不是青年。");
}