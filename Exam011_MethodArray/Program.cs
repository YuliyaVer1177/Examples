int [] array = { 1, 12, 31, 4, 15, 16, 17, 18, 15};

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if(array [index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index ++;
}
