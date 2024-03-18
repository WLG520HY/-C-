//2006年培养学员80000人，每年增长25%，问按此增长速度，哪一年达到20万人？
//int nian = 2006;
//double i = 80000;
//while(i<=200000)
//{
//    i *= 1.25;
//    nian++;
//}
//Console.WriteLine(nian);

//输入学生的个数，然后输入每一个学生的年龄，输出计算平均年龄保留小数点后两位。
//Console.WriteLine("输入一共有几个学生。");
//int xs = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("依次输入学生的年龄。");
//int i = 1;
//int he = 0;
//while (i<xs+1)
//{
//    he  += Convert.ToInt32(Console.ReadLine());
//    i++;
//}
//double pin =(he*1.00)/ xs;
//Console.WriteLine((double)((int)(pin * 100))/100);

//输入一个整数n，输出1~n中的每个数，空格隔开。
Console.WriteLine("输入任意一个整数。");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while(1<n)
{
    i++;
    Console.Write(i+" ");
    if (i == n)
    {
        break;
    }
}