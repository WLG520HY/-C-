//让用户输入整数，如果是0结束程序并输出所有整数的和。
//Console.WriteLine("输入任意整数，按0结束输入。");//提示用户输入
//int n = 1;//定义一个n用来接收用户输入的整数
//int 和 = 0;//定义一个和
//for (; n != 0;)//满足if的条件判断时执行的循环
//{
//    n = Convert.ToInt32(Console.ReadLine());//接收用户输入的数据
//    和 += n;//计算输入的所有整数和
//    if(n==0)//判断用户输入的整数，是零的话跳出循环
//    {
//        break;//跳出语句
//    }
//}
//Console.WriteLine(和);//输出计算后的和

//用while循环写
//Console.WriteLine("输入任意数字，按0结束。");
//int i = 1;
//int he = 0;
//while(i!=0)
//{
//    int a = Convert.ToInt32(Console.ReadLine());
//    he += a;
//    if(a==0)
//    {
//        break;
//    }
//}
//Console.WriteLine(he);

//用do-while循环写
//Console.WriteLine("输入任意整数，按0停止输入并输出之前所有整数的和。");
//int he = 0;
//int i = 1;
//int a;
//do
//{
//    a = Convert.ToInt32(Console.ReadLine());
//    he += a;
//    if(a==0)
//    { break; }
//} while (a != 0);
//Console.WriteLine(he);

//一个球从高处落下，每次落地后反弹原来的一半，计算第十次反弹多高，
//和第十次落地一共经过多少米。
//输入球的初始高度，输出反弹多高，和经过了多少米。
//Console.WriteLine("输入球的初始高度");
//int n = Convert.ToInt32(Console.ReadLine());//定义一个变量来接收输入的球高。
//double gaodu = n;
//for (int i = 0; i < 10; i++)
//{
//    gaodu /= 2;
//}
//Console.WriteLine("第十次反弹后的高度是{0}", gaodu);
//double juli = n * 2;
//double julihe = n;
//for (int i = 0; i < 9; i++)
//{
//    juli /= 2;
//    julihe += juli;
//}
//Console.WriteLine("第十次反弹后的总距离是{0}", julihe);

//Console.WriteLine("输入球的初始高度（单位：米）：");
//double initialHeight = Convert.ToDouble(Console.ReadLine());
//double currentHeight = initialHeight;
//double totalDistance = 0;
//for (int i = 0; i < 10; i++)
//{
//    totalDistance += currentHeight; // 累加下落距离
//    currentHeight /= 2; // 反弹后的高度为原高度的一半
//    totalDistance += currentHeight; // 累加上升距离
//}
//Console.WriteLine("第十次反弹后的高度是：" + currentHeight + " 米");
//Console.WriteLine("第十次反弹后的总距离是：" + totalDistance + " 米");

//输入一共整数a，和一个整数n，计算乘方a的n次方。
//Console.WriteLine("输入整数a的值。");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入整数n的值。");
//int n = Convert.ToInt32(Console.ReadLine());
//int 结果 = 1;
//for (int i=0; i<n; i++)
//{
//    结果 *= a;
//}
//Console.WriteLine("结果是{0}", 结果);

//输入整数n，输出n的阶乘
//Console.WriteLine("输入任意整数。");
//int n = Convert.ToInt32(Console.ReadLine());
//int 结果 = 1;
//for (int i = 1; i <= n; i++)
//{
//    结果 *= i;
//}
//Console.WriteLine("{0}的阶乘是{1}", n, 结果);

//输入q和n的值，求1+q1+q2+……qn的结果
//Console.WriteLine("输入q的值。");
//int q = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入n的值。");
//int n = Convert.ToInt32(Console.ReadLine());
//int jieguo = 1;
//int jieguo1 = 1;
//for(int i=0;i<n;i++)
//{
//    jieguo *= q;
//    jieguo1 += jieguo;
//}
//Console.WriteLine("结果是{0}", jieguo1);

//Sn=1+1/2+1/3+……1/n，当n足够大的时候Sn大于K。现在输入一个k（1<=K<=15），输出一个最小的n使Sn>K.
//Console.WriteLine("输入K的值，要求K大于等于1小于等于15。");
//int K = Convert.ToInt32(Console.ReadLine());
//double Sn = 0;
//int i = 1;
//for(; Sn<=K;i++)
//{
//    Sn += (1.0 / i);
//}
//Console.WriteLine(i-1);

//我国现有x亿人口，按照每年0.1%增长速度，n年后将有多少人？
//Console.WriteLine("输入人口多少亿？");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("几年后？");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    x *= 1.001;
//}
//Console.WriteLine("{0}年后的人口是{1}", n, x);

//年利率是R（0~20）
//本金是M（100~1000000）
//投资的年限（0~400）
//Console.WriteLine("输入本金的数量。");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入利率。");
//int r = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("输入投资的年限。");
//int y = Convert.ToInt32(Console.ReadLine());
//for (int i = 0;i<y;i++)
//{
//    m = (int)(m*((r / 100.0) + 1));
//}
//Console.WriteLine("最终拥有了{0}块钱。", m);

//求三位数的水仙花数
//水仙花数示例：153=1*1*1+5*5*5+3*3*3
//int ge;
//int shi;
//int bai;
//int jieguo = 0;
//for(int i=100;i<=999;i++)
//{
//    ge = i % 10;
//    shi = (i / 10) % 10;
//    bai = i / 100;
//    jieguo = bai * bai * bai + shi * shi * shi + ge * ge * ge;
//    if (jieguo == i)
//    { Console.WriteLine("三位数的水仙花数是{0}", jieguo); }
//}

//输入任意一位未知位数的整数，依次输出每一个数字，从个位开始。
//Console.WriteLine("输入任意整数。");
//int n = Convert.ToInt32(Console.ReadLine());
//while(n!=0)
//{
//    int i = n % 10;//求个位上的数字
//    Console.WriteLine(i);//输出个位上的数字
//    n = n / 10;//舍弃已经输出的个位数，让循环重新计算个位数
//}

//输入任意数，去除这个数中所有的0，输出新的数。
//Console.WriteLine("输入任意数。");
//int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//int cheng = 1;
//while(n!=0)
//{
//    int i = n % 10;
//    if(i!=0)
//    {
//        i *= cheng;
//        sum += i;
//        cheng *= 10;
//    }
//    n = n / 10;
//}
//Console.WriteLine(sum);

//随机输入一个整数，输出一个新的数，与原来的数相反，去除零
//Console.WriteLine("输入任意整数。");
//int n = Convert.ToInt32(Console.ReadLine());
//int unm = 0;
//int cheng = 1;// 用来中间乘算的变量
//while(n!=0)//循环条件输入的n不为零开始循环
//{
//    int i = n % 10;//计算个位上的数字
//    if(i!=0)//条件判断上面计算后的i储存的个位数不等于零执行下面的代码
//    {
//        i *= cheng;
//        unm += i;//最后的就是去除零后新的整数
//        cheng *= 10;
//    }
//    n = n / 10;
//}
//while(unm!=0)
//{
//    int i = unm % 10;
//    Console.Write(i);
//    unm /= 10;
//}

//判断回文数，是就输出yes，不是输出no
//Console.WriteLine("输入任意整数。");
//int n = Convert.ToInt32(Console.ReadLine());
//int zhenshu = n;
//int daoshu = 0;
//while(n!=0)
//{
//    int i = n % 10;
//    daoshu = daoshu * 10 + i;
//    n = n / 10;
//}
//if(zhenshu==daoshu)
//{
//    Console.WriteLine("是回文数。");
//}
//else if(zhenshu!=daoshu)
//{
//    Console.WriteLine("不是回文数。");
//}

//输入一串混合数字的字符串，识别数字进行相加，输入@结束
//Console.WriteLine("输入任意字符串。");
//char n;
//int he = 0;
//do
//{
//    n = Convert.ToChar(Console.Read());
//    if (n >= '0' && n <= '9')
//    {
//        int number = n - '0';
//        he += number;
//    }
//} while (n != '@');
//Console.WriteLine(he);

//输入一串字符，#号结束其中*号价值500，其余1~9，输出挖到的总金额。
//Console.WriteLine("输入矿洞的组成#号结束。");
//char n;
//int he = 0;
//do
//{
//    n = Convert.ToChar(Console.Read());
//    if (n == '*')
//    {
//        he += 500;
//    }
//    else if (n >= '0' && n <= '9')
//    {
//        int number = n - '0';
//        he += number;
//    }
//} while (n != '#');
//Console.WriteLine("矿工一共挖到了{0}美金。", he);

//输入一个整数，输出这个整数的因数个数和所有的因素。
//Console.WriteLine("输入一个整数。");
//int n = Convert.ToInt32(Console.ReadLine());
//int jishu = 0;
//string str = "";
//for (int i = 1; i <= n; i++)
//{
//    if (n % i == 0)
//    {
//        jishu++;
//        str += i + " ";
//    }
//}
//Console.WriteLine($"因数个数为: {jishu}");
//Console.WriteLine(str);

//输入一个整数，判断是否是质数（只能被1和自身整除的数就是质数）
//Console.WriteLine("输入一个整数。");
//int n = Convert.ToInt32(Console.ReadLine());
//int jishu = 0;
//for (int i = 1; i<=n; i++)
//{
//    if(n%i==0)
//    {
//        jishu++;
//    }
//}
//if (jishu == 2)
//{
//    Console.WriteLine("是质数。");
//}
//else
//{
//    Console.WriteLine("不是质数。");
//}

//输出1~100中所有的奇数
for (int i = 1; i <= 100; i++)
{
    if(i%2!=0)
    {
        Console.WriteLine(i);
    }
}