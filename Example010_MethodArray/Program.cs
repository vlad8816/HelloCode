int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;// алгоритм завершил работу, так как уже нашел индекс искомого числа, без break, он бы показал 4 и 8, то есть все индексы искомого числа в массиве 
    }
    //index= index+1;
    index++;
}