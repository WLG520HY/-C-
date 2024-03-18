//输入一个三位正整数，按数字的相反顺序输出
Console.WriteLine("请输入一个三位数");
int shu = Convert.ToInt32(Console.ReadLine());
int 个位 = shu % 10;
int 十位 = (shu / 10) % 10;
int 百位 = shu / 100;
int 倒叙整数 = 个位 * 100 + 十位 * 10 + 百位;
Console.WriteLine("这个数的倒叙是{0}",倒叙整数);