# Решение Задачи 

## Начало
1. Создаем функцию с принимающими ей аргументами массив**(array)** и разделитель **(elements)** по которому будет сформирован новый массив если длина основного  
элемента массива**(array)** меньше или равна **(elements)**.

        string[] ParseArray(string[] array, int elements)

2. Внутри функции создаем пустой массив с размером длины элементов основного массива для дальнейшей сортировки элементов

        string[] result = new string[array.Length];

3. Создаем еще одну переменную **(count)** она нам понадобиться для выставления элементов осовного массива у которыъ длина меньше или равна **(elements)** и так же для **resize** нашего пустого массива под нужный размер

        int count = 0;

4. Запускаем цикл по всей длине основного массива

        for (int i = 0; i < array.Length; i++)

5. В цикле мы проверяем из скольки символов состоит элемент массива.

        if (array[i].Length <= elements)

6. Если элемент меньше или равен **(elements)** то мы его добавляем в новый массив который мы создали ранее под индексом **count** и увеличеваем переменную **count** на 1

        result[count] += array[i];
        count++;

7. Если элемент больше или не равен **(elements)** то переходим к следующему элементу нашего основного массива
8. Как все элементы основного массива были проверены мы делаем resize массива в который добавляли элементы которые меньше или равны размеру (elements) с помощью переменной (count).

        Array.Resize(ref result, count);

9. Возвращаем массив с отсортированными элементами.

        return result;

10. Создаем новую функцию void для отображения(печати) нашего массива

        void PrintArray(string[] array)
        {
            System.Console.WriteLine($"[{String.Join(", ",array)}]");
        }

11. Задание решено(Полный код задания)


        string[] ParseArray(string[] array, int elements)
        {
            string[] result = new string[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= elements)
                {
                    result[count] += array[i];
                    count++;
                }
            }
            Array.Resize(ref result, count);
            return result;
        }

        void PrintArray(string[] array)
        {
            System.Console.WriteLine($"[{String.Join(", ",array)}]");
        }

        string[] array = { "hello", "2", "world", ":-)" };
        string[] arrayParse = ParseArray(array, 3);
        PrintArray(array);
        System.Console.WriteLine();
        PrintArray(arrayParse);
