﻿void FillArray(int[] collection) // создаем метод с массивом, значения которого не нужно возвращать (void)
{
    int length = collection.Length; // ввели переменную, равную длине массива .Length
    int index = 0;// присваиваем переменной index значение 0
    while(index < length)// пока индекс меньше значения длины массива выполняем 
    {
        collection[index] = new Random().Next(1, 10);// заполняем наш массив(index изначально равен 0, так как это мы обозначили перед циклом) случайными числами 0..10
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) // создаем метод "PrintArray" с массивом "col"
{
    int count = col.Length;// переменная "count" равна длине массива "col" 
    int position = 0;// вводим переменную "position" со значением 0
    while(position < count )// пока значение переменной "position" меньше значения переменной "count" выполняем... 
    {
        Console.WriteLine(col[position]);// Вывести на экран с новой строки значения массива с индексом "position"(в самом начале 0, так как обоззначили это перед циклом
        position++;// увеличиваем значение переменной "position" на 1 и возвращаемся в начало цикла, 
        //цикл повторяется пока значение переменной "position" не достигнет конца длины массива
    }
}

int IndexOf(int[] collection, int find)// метод возвращения позиции(индекса), метод называется "IndeOf" в качестве аргумента используем массив "collection" и элемент "find"
{
    int count = collection.Length;// переменная "count" равна длине массива "collection"
    int index= 0;// вводим переменную "index" со значением 0
    int position = -1;// в программирование означает, что если элемента нет, то выводится значение "-1"
    while (index < count)// пока значение переменной "index" меньше значения переменной "count" выполняем... 
    {
        if(collection[index] == find)// Если значение массива соотвествует значению "find",то выполняем...
        {
            position = index;// значению переменной "position" присваиваем значение переменной 'index'
            break;// как только находим необходимое значение(position = index) прекращаем выполнение цикла, если не поставить "break", 
                // то цикл продолжится даже после нахождения необходимого значения
        }
        index++;// увеличиваем index на 1
    }
    return position;// возвращаем значение переменной 'position'
}

int[] array = new int[10]; // new int[10]- создай новый массив, в котором будет 10 элементов

FillArray(array);//вызываем метод FillArray с аргументом array( массив,который создали выше с 10 элементами)
array[4] = 4;// присвоили 4 элементу в массиве значение 4
array[6] = 4;// присвоили 6 элементу в массиве значение 4
PrintArray(array);// вызываем метод PrintArray с аргументом array
Console.WriteLine();

int pos = IndexOf(array, 44);//определили переменную pos и в нее положили результаты работы метода IndeOf, в качестве аргумента передаем методу наш массив и ищем число 44
Console.WriteLine(pos);