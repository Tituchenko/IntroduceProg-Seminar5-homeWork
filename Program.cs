
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] arr=GetArray (7,100,999);

printArray(arr);
Console.WriteLine ($" -> {getEvenElements(arr)}");


int getEvenElements (int[] arr)
{
    int count=0;
    for (int i=0;i<arr.Length;i++){
        if (arr[i]%2==0) count++;
    }
    return count;
}

//Создание массива
int[] GetArray(int size,int min,int max)
{
    int[] res= new int[size];
    for (int i=0;i<size;i++){
        res[i]=new Random().Next(min,max+1);
    }
    return res;
}

/*
//Ввод масива через терминал
int[] GetArrayFromString()
{
    Console.Write ("Введите массив элементов через пробел:");
    string s= Console.ReadLine();
    string[] tempStringArray=s.Split(" ");
    int[] res= new int[tempStringArray.Length];
    for (int i=0;i<tempStringArray.Length;i++){
        res[i]=int.Parse(tempStringArray[i]);
    }
    return res;
}
*/
//Вывод массива
void printArray (int[] arr)
{
    Console.Write ($"[{String.Join(",",arr)}]");
}