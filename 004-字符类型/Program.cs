// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//char a = 'c';
//int b = a;
//Console.WriteLine(a);
//Console.WriteLine(b);
//将数字97转换成字符a
//int a = 97;
//Console.WriteLine(a);
//char b = (char)a;//强制类型转换
//Console.WriteLine(b);
//char a = '\n';
//char b = '\"';
//char c = '\\';
//char d = '\t';
//char e = '\'';
//Console.WriteLine("C:\\a\\b\\c");//转义字符正常使用
//Console.WriteLine(@"C:\a\b\c");//@符号能取消转义字符的功能
//@符号要在""外面使用
//string str = "C:\\a\\b\\c";//转义字符在字符串里面使用也是一样的正常使用
//string str1 = @"C:\a

//\b""

//\c";//@符号同理也能取消字符串里面的转义功能
//@符号要在""外面使用
//@符号的第二个作用，可以让字符串随意换行
//在使用@时单引号的转义责任由单引号本身实现
//Console.WriteLine(str1);

//string str = "123" + "456";
//string str1 = str + "啊吧啊吧";
//Console.WriteLine(str1);
//+号能让两个字符串合并
Console.WriteLine("请输入一串任意数字，控制台将打印出来。");
string str = Console.ReadLine();
int strint = Convert.ToInt32(str);//这两串代码可以合并成一串
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(strint + "&" + a);