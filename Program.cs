//Задача2
//*/
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
