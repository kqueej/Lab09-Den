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