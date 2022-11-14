
Console.Clear();

string [] CreateArray(int number) {
    string[] array = new string[number];
    return array;
}

void FillArray(string[] array) {
    for (int i = 0; i < array.Length; i += 1) {
        string word = Console.ReadLine()!;
        array[i] = word;
    }
}

string[] SortArray(string[] sort, int length) {
    string[] newSort = new string[length];
    for (int i = 0, j = 0; i < sort.Length; i += 1) {
        if (sort[i].Length <= 3) {
            newSort[j] = sort[i];
            j += 1;
        } 
    }
    return newSort;    
}

int CountLines(string[] sort) {
    int count = 0;
    for (int i = 0; i < sort.Length; i += 1) {
        if (sort[i].Length <= 3) {
           count += 1;
        }
    }
    return count;
}

void PrintArray(string[] print) {
    Console.Write("[");
    for (int i = 0; i < print.Length; i += 1) {
        Console.Write($"\"{print[i]}\"");
        if ( i != print.Length - 1 ) {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

string[] arr = CreateArray(n);
Console.WriteLine("Введите строки: ");
FillArray(arr);
int stringLength = CountLines(arr);
string[] result = SortArray(arr, stringLength);
Console.Write("Вы ввели: ");
PrintArray(arr);
Console.Write("Строки из трех и менее символов: ");
PrintArray(result);