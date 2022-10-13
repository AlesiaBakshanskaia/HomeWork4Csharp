//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*Console.WriteLine("Введите положительное число А");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите положительное число В");
int B = int.Parse(Console.ReadLine()!);

if (A < 0 || B <0){
    Console.WriteLine($"Вы не верно ввели одно из чисел");
}
else{
Console.WriteLine($"Число {A} в степени {B} равно {Power(A, B)}");
}


int Power(int num1, int num2){
    int result = 1;
    for (int i = 0; i < num2; i++){
        result = result * num1;

    }
    return result;

}*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Введите положительное число");
string num = Console.ReadLine()!;

if (num[0] == '-') {
    Console.WriteLine("Вы ввели отрицательное число");
}
else {
    Console.WriteLine($"Сумма цифр числа {num} равна {GetSum(num)}");
}


int GetSum(string num){
    int[] array = new int [num.Length];
    for (int i = 0; i < num.Length; i++){
        array[i] = Convert.ToInt32(num[i].ToString());
   // Console.WriteLine($"{array[i]}");
    }

    int result = 0;
    for (int i = 0; i < array.Length; i++){
        result += array[i];
    }
    return result;
}


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*int[] Array = GetArray(8);
Console.WriteLine($"[{String.Join(",", Array)}]");

int[] GetArray(int lenght){
    int[] collection = new int[lenght];
    for (int i = 0; i < lenght; i++){
        collection[i] = new Random().Next(10000);
    }
    return collection;
}*/