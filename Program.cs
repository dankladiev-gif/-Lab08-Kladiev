int totalLessons = 5;
int lessonNumber = totalLessons; // Начинаем с последнего урока

while (lessonNumber >= 1) 
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--; // Уменьшаем номер урока на 1
}

Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён");

int sum = 0;
int count = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
grade = int.Parse(Console.ReadLine());

while (grade != -1) {
    sum += grade;
    count++;
    grade = int.Parse(Console.ReadLine());
}

if (count > 0) {
    Console.WriteLine($"Средний балл: {(double)sum / count}");
} else {
    Console.WriteLine("Оценок не было введено");
}

string correctPassword = "qwerty123";
int failedAttempts = 0; // Переменная-счетчик для неудачных попыток

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();
    
    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        Console.WriteLine($"Количество неудачных попыток: {failedAttempts}");
        break;
    }
    
    failedAttempts++; // Увеличиваем счетчик, если пароль неверный
    Console.WriteLine("Неверный пароль, попробуйте снова");
}