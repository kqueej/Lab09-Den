// Step 2
// class Program
// {
//     static void Main()
//     {
//         int[] scores = [5, 4, 3, 5, 4];
//         Console.WriteLine($"First element: {scores[0]}");
//         Console.WriteLine($"Last element: {scores[scores.Length - 1]}");
//         scores[2] = 5;
//         Console.WriteLine($"Array: {string.Join(", ", scores)}");
//     }
// }

// Step 3
// class Program
// {
//     static void Main()
//     {
//         int[] scores = [5, 4, 3, 5, 4];

//         // Здесь for удобнее foreach, потому что нам необходимо знать индекс каждого элемента 
//         for (int i = 0; i < scores.Length; i++)
//         {
//             Console.WriteLine($"Index {i}: {scores[i]}");
//         }

//         Console.WriteLine();

//         foreach (int score in scores)
//         {
//             Console.WriteLine(score);
//         }
//     }
// }

// Step 4
/*
1. До ошибки успели вывести: 10, 20, 30

2. В момент ошибки i = 3, а Length = 3

3. При i = 3 программа пытается обратиться к numbers[3], но допустимые индексы это 0, 1 и 2.

4. Нужно заменить i <= numbers.Length на i < numbers.Length
*/

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = [10, 20, 30];

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine(numbers[i]);
//         }
//     }
// }

// Step 5
// class Program
// {
//     static void Main()
//     {
//         int[] data = [1, 2, 3];

//         Console.WriteLine($"Before: {string.Join(", ", data)}");
//         ChangeFirst(data);
//         Console.WriteLine($"After: {string.Join(", ", data)}");
//     }
//     static void ChangeFirst(int[] array)
//     {
//         array[0] = 100;
//     }
// }

// Step 6
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = [1, 2, 3, 4, 5];

//         Console.WriteLine($"Before: {string.Join(", ", numbers)}");
//         MultiplyByTwo(numbers);
//         Console.WriteLine($"After: {string.Join(", ", numbers)}");
//     }
//     static void MultiplyByTwo(int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] *= 2;
//         }
//     }
// }

/*
Метод не использует ref, потому что массив является
ссылочным типом. Не логично

При передаче массива в метод копируется ссылка
на тот же самый массив

Поэтому изменение array[i] внутри метода
изменяет исходный массив

ref нужен для изменения самой переменной-ссылки,
а не для изменения элементов массива.
*/

// Step 7
// class Program
// {
//     static void Main()
//     {
//         int[] data = [7, -3, 12, 0, 5, 9, -8];

//         int sum = 0;
//         int max = data[0];
//         int min = data[0];

//         double average = (double)sum / data.Length;

//         for (int i = 0; i < data.Length; i++)
//         {
//             sum += data[i];

//             if (data[i] > max)
//             {
//                 max = data[i];
//             }

//             if (data[i] < min)
//             {
//                 min = data[i];
//             }
//         }

//         Console.WriteLine($"Сумма: {sum}");
//         Console.WriteLine($"Среднее: {average:F2}");
//         Console.WriteLine($"Максимум: {max}");
//         Console.WriteLine($"Минимум: {min}");
//     }
// }

// Step 8
// class Program
// {
//     static void Main()
//     {
//         int[] negative = [-5, -2, -9];

//         int max = negative[0];
//         int min = negative[0];

//         for (int i = 0; i < negative.Length; i++)
//         {
//             if (negative[i] > max)
//             {
//                 max = negative[i];
//             }

//             if (negative[i] < min)
//             {
//                 min = negative[i];
//             }
//         }

//         Console.WriteLine($"Максимум: {max}");
//         Console.WriteLine($"Минимум: {min}");

//         /*
//         Если начать с 0, то мы в целом не сможем получить свое, так как элементы все меньше 0
//         Логично просто использовать первый элемент массива
//         */
//     }
// }

// Step 9
// class Program
// {
//     static void Main()
//     {
//         int size = ReadPositiveInt("Array size: ");

//         int[] numbers = new int[size];

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = ReadInt($"Element {i + 1}: ");
//         }

//         Console.WriteLine();
//         Console.WriteLine(
//             $"Array: {string.Join(", ", numbers)}"
//         );
//     }

//     static int ReadPositiveInt(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);

//             string input = Console.ReadLine()!;

//             if (int.TryParse(input, out int value))
//             {
//                 if (value > 0)
//                 {
//                     return value;
//                 }
//             }
//             Console.WriteLine("Error: Enter number > 0 and integer");
//         }
//     }
//     static int ReadInt(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);

//             string? input = Console.ReadLine();

//             if (int.TryParse(input, out int value))
//             {
//                 return value;
//             }
//             Console.WriteLine("Error: enter integer number");
//         }
//     }
// }