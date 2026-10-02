int totalLessons = 5;
int lessonNumber = totalLessons; // Начинаем с последнего урока

while (lessonNumber >= 1) 
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--; // Уменьшаем номер урока на 1
}

Console.WriteLine("Пары закончились");

Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

int count = 0; // 1. Создаём счётчик оценок

while (grade != -1) 
{
    count++; // 2. Увеличиваем счётчик при каждом проходе цикла
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён");
Console.WriteLine($"Всего введено оценок: {count}"); // 3. Выводим результат


