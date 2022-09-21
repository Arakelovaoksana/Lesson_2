// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
     
     Console.Clear();
      Console.Write("Введите кол-во чисел для вывода:");
            int N = int.Parse(Console.ReadLine()!);
 
            Console.WriteLine("Число" + "\t" + "Куб");
            for(int i = 1; i <= N; i++)
                Console.WriteLine(i + "\t" + i*i*i);
 
            Console.ReadLine();
  
        
    