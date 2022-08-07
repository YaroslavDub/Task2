// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int third = Convert.ToInt32(Console.ReadLine());
if (first > second && first > third) {
    Console.WriteLine("Самое большое число: "+ first);
}
else if (second > first && second > third) {
    Console.WriteLine("Самое большое число: "+ second);
}
else if (third > first && third > second) {
    Console.WriteLine("Самое большое число: "+ third);
}
else if (first == second && second == third) {
    Console.WriteLine("Все числа имеют одинаковое значение: "+ first);
}
else if (first == second) {
    Console.WriteLine("первое и второе число имеют максимальное значение: "+ first );
}
else if (first == third) {
    Console.WriteLine("первое и третье число имеют максимальное значение: "+ first );
}
else if (first == second) {
    Console.WriteLine("второе и третье число имеют максимальное значение: "+ second );
}