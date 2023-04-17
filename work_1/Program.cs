//первый вид. Ничего не принимает и ничего не возвращает
void Method1()
{
    System.Console.WriteLine("Автор, Савинов Сергей");
}
Method1();

//второй вид. Ничего не возвращают, но могут принимать аргументы.
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("Текст");

void Method2_1(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method2_1("Текст", 4);   //или еще можно указать явно- Method2_1(msg: "новый текст", count: 4)

//третий вид. Что-то возвращают, но ничего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

int yaer = Method3();
System.Console.WriteLine(yaer);

//четвертый вид. Что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;           //string.Empty означает, что мы присвоили пустую строку

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
System.Console.WriteLine(res);

string Method4_1(int count, string text)
{
    string result = string.Empty;           
    for(int i = 0; i < count; i++)          //в строке for пишется инициализация счетчика(int i = 0;), проверка условия(i < count) и увиличение счетчика(i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method4_1(10, "asdf");
System.Console.WriteLine(res);
