
            // 1. Исходный массив
            int[] Masiv = { 10, 20, 30, 40, 50 };

            // 2. Вывод исходного массива
            Console.Write("Исходный массив: ");
            for (int i = 0; i < Masiv.Length; i++)
            {
                Console.Write(Masiv[i] + " ");
            }
            Console.WriteLine();

            // 3. Создаём новый массив такого же размера
            int[] Masiv2 = new int[Masiv.Length];

            // 4. Заполняем новый массив в обратном порядке
            for (int i = 0; i < Masiv.Length; i++)
            {
    Masiv2[i] = Masiv[Masiv.Length - 1 - i];
            }

            // 5. Вывод перевернутого массива
            Console.Write("Перевернутый массив: ");
            for (int i = 0; i < Masiv2.Length; i++)
            {
                Console.Write(Masiv2[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
 