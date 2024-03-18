//根据用户输入的数字显示用户购买的商品
//1：矿泉水
//2：红茶
//3：绿茶
//4：雪碧
//5：可口可乐
//6：脉动
//Console.WriteLine("输入1~6选择商品。");
//int a = Convert.ToInt32(Console.ReadLine());
//if(a==1)
//{
//    Console.WriteLine("矿泉水。");
//}
//else if(a==2)
//{
//    Console.WriteLine("红茶。");
//}
//else if(a==3)
//{
//    Console.WriteLine("绿茶。");
//}
//else if(a==4)
//{
//    Console.WriteLine("雪碧。");
//}
//else if(a==5)
//{
//    Console.WriteLine("可口可乐。");
//}
//else if(a==6)
//{
//    Console.WriteLine("脉动。");
//}
//第二种方法
//switch(a)
//{
//    case 1:
//        Console.WriteLine("矿泉水。");
//        break;
//    case 2:
//        Console.WriteLine("红茶。");
//        break;
//    case 3:
//        Console.WriteLine("绿茶。");
//        break;
//    case 4:
//        Console.WriteLine("雪碧。");
//        break;
//    case 5:
//        Console.WriteLine("可口可乐。");
//        break;
//    case 6:
//        Console.WriteLine("脉动。");
//        break;
//    default:
//        Console.WriteLine("没有你选的饮料。");
//        break;
//}

//输入今天星期几，输出今天要上的课
Console.WriteLine("输入星期几");
string a = Console.ReadLine();
switch(a)
{
    case "星期一":Console.WriteLine("今天上语文课。");
        break;
    case "星期二":Console.WriteLine("今天上数学课。");
        break;
    case "星期三":Console.WriteLine("今天上历史课。");
        break;
    case "星期四":Console.WriteLine("今天上品德课。");
        break;
    case "星期五":Console.WriteLine("今天上音乐课。");
        break;
    case "星期六":Console.WriteLine("今天上体育课。");
        break;
    case "星期七":Console.WriteLine("今天上外语课。");
        break;
    default:Console.WriteLine("咋滴，一周七天还不够给你上课啊？");
        break;
}