void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index=index + 1;
        index ++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col [position]); //значение текущего элемента
        position++;
    }
}

int  indexOf(int[] collection, int find) //будет приходить массив collection и элемент find
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемента нет выводит -1 (такой элемент не найден)
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];

FillArray(array); //заполняет массив
array[4] = 4;
array[6] = 4;

PrintArray(array); //распечатывает массив
Console.WriteLine();

int pos = indexOf(array, 444);
Console.WriteLine(pos);
