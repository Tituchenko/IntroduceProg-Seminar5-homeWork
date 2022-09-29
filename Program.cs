



//Создание массива
int[] GetArray(int size,int min,int max)
{
    int[] res= new int[size];
    for (int i=0;i<size;i++){
        res[i]=new Random().Next(min,max+1);
    }
    return res;
}

//Вывод массива
void printArray (int[] arr)
{
    Console.WriteLine ($"[{String.Join(",",arr)}]");
}