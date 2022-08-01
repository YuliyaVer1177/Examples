// ВИД 1 Метод ничего не возвращает (если закомитить // выход какого-то метода, то на экран выйдут, те что остались)
void Method1()
{
    System.Console.WriteLine("Автор.....");
}
Method1();

//ВИД 2
void Method2(string msg) //message
{
    System.Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count) //message текст и сколько раз он повторится
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст",  2); если использовать название значений, то их можно ставить в любом порядке 
Method21(count: 2, msg: "новый текст"); 

//ВИД 3 метод что-то возвращает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

//ВИД 4 Метод что-то принимает и возвращает
string Method4(int count, string text)
/*{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}*/
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

for (int i = 2; i <= 5; i++)
{
    for (int j = 2; j <= 5; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i*j}");
    }
    System.Console.WriteLine(); // вывод на новую строку, в данном примере для разрывов столбиков
}