﻿//Задача2
/*/
Console.Write("Введите первое число: ");
int A= int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int B= int.Parse(Console.ReadLine()!);
if (A>B) {
    Console.Write($"Большее число равно {A}, а ");
    Console.Write($"меньшее число равно {B}");
} else if (A<B) {
    Console.Write($"Большее число равно {B}, а ");
    Console.Write($"меньшее число равно {A}");
} else {
    Console.Write("Введенные числа равны!");
}
//*/

//Задача4
//*/
Console.Write("Введите первое число: ");
int A= int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int B= int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int C= int.Parse(Console.ReadLine()!);

const int dim= 3;
int[] mas=new int[dim]{A,B,C};
int max= mas[0];

for(int i=1;i<dim;i++) {
    if(mas[i]>max) {
        max=mas[i];
    };
}
Console.Write($"Наибольшее число равно {max}");
//*/

