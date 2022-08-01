// === Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "В" заменит маленькими "в".

//Ясна ли задача?

string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

 // string s = "qwerty"
 //             012345
 // s[3] // r
 string Replace(string text, char oldValue, char newValue ) // 4 ВИД МЕТОДОВ char - конкретный символ; Replase - заменять
 {
    string result = String.Empty; //ИНИЦИАЛИЗАЦИЯ ПУСТОЙ СТРОКИ

    int length = text.Length;
    for (int i = 0;  i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}"; //аргумент текст значит выбираем правильный аргумент - текст
    }

    return result;
 }  
 
string newText = Replace(text, ' ', '|'); //вертикальный символ взяли для наглядности

System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
newText = Replace(newText, 'В', 'в');
System.Console.WriteLine(newText);


// КОД ЗАПУСКАЕТСЯ СО ВТОРОГО РАЗА / не поняла почему, возможно ошибки