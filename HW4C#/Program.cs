//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите положительное число А");
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

}