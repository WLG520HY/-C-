//怎么交换两个变量的值
//int a = 1, b = 2, c;//声明变量
//c = a;a = b;b = c;//交换变量
//Console.WriteLine(a + "\n" + b);//这是使用临时变量倒腾的方法

//第二种方法，通过计算调换变量
//int a = 5, b = 10;
//a = a + b;//将a和b的和赋值给a
//b = a - b;//将和减去b就是原来a的值然后赋值给b
//a = a - b;//将和减去赋值后的b（原来的a）就是b赋值给a
//Console.WriteLine(a + "\n" + b);

//字符串格式化输出
int a = 45, b = 28;
//输出a+b=和
Console.WriteLine(a + "+" + b + "=" + (a + b));
Console.WriteLine("{0}+{1}={2}", a, b, a + b);