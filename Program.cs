// int[] recordBooks = {1042, 1058, 1071, 1093, 1105};
// int target = 1067;
// bool found = false;
// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");


// int variant = 1;
// if (variant <= 1)
// {
//     Console.WriteLine("Число не является ни простым, ни составным");
// } else
// {
//     bool isPrime = true;
//     for (int divisor = 2; divisor < variant; divisor++)
//     {
//         if (variant % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
// } 

// int[] pointsPerLab = {8,-1,10,9,-1,7};
// int sum = 0;
// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Сколько работ было сдано: {sum}");

// int[] groupIds = {101,104,107,104,110};
// bool HasDuplicates = false;
// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
// Console.WriteLine(groupIds[i] + " и " + groupIds[j]);
//             return;
//         }

//     }
// }
// Console.WriteLine("Все номера уникальны");


// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;
// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);
//         if (isFree)
//         {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }
// if (!found)
// {
//     Console.WriteLine("Свободных мест нет");
// }


// int[] numbers = {1,2,3,4,5};
// int sum = 0;
// foreach (int number in numbers)
// {
//     if (number % 2 != 0)
//     {
//         continue;
//     }
//     sum += number;
// }
// Console.WriteLine(sum);


// int[] numbers = {1,2,3,4,5};
// int num = 8;
// bool flage = false;
// int numIndex = 0;
// foreach (int number in numbers)
// {
//     if (number == num)
//     {
//         flage = true;
//         break;
//     }
//     numIndex++;
// }
// if (flage)
// {
//     Console.WriteLine(numIndex);
// }
// else
// {
//     Console.WriteLine("Индекс не найден");
// }


// Console.WriteLine("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1,10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// int[] numbers = {1,2,3,4,5};
// int sum = 0;
// foreach (int number in numbers)
// {
//     if (number % 3 == 0)
//     {
//         continue;
//     }
//     sum += number;
// }
// Console.WriteLine(sum);


using System.Globalization;

int[] numbers = {1,-2,3,4,5,-6};
int count = 0;
for (int i = 0; i<numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        break;
    }
    count++;
}
Console.WriteLine(count);
ssssssssssssssssssssss