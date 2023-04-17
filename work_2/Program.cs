for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}

//Работа с текстом. В тексте нужно заменить все пробелы на черточки.
//Маленькие буквы "к" заменить на "К" и большие бкувы "С" на маленькие "с".

string text = "-Я думаю, - сказал Князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля"
            + "Вы так красноречивы. Вы дадите мне чаю";
//string s = "qwdcfva"
//            0123456
//s[3]  // c

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);