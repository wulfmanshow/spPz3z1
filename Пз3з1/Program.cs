//Первые 3 задания
//void metod(int a,int b)
//{  
//    for (int i = a; i < b; i++)
//    {
//        Console.WriteLine($"{i} - {Thread.CurrentThread.ManagedThreadId}");
//    }
//}
//Console.WriteLine("input start and end of range: ");
//int start=Convert.ToInt32(Console.ReadLine()),end= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("count of Threads: ");
//int countOfThreads = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < countOfThreads; i++)
//{
//    Thread thread = new Thread(() => metod(start, end));
//    thread.Start();
//}



//задание 4+
//Random random = new Random();
//int max=0, min=0;
//double avg=0;
//void MaxNumber(int[] mas)
//{
//    max = mas[0];
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (max < mas[i])
//        {
//            max = mas[i];
//        }
//    }
//}
//void MinNumber(int[] mas)
//{
//    min = mas[0];
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (min > mas[i])
//        {
//            min = mas[i];
//        }
//    }
//}
//void AvgNumber(int[] mas)
//{
    
//    for (int i = 0; i < mas.Length; i++)
//    {
//        avg += mas[i];
//    }
//    avg /= mas.Length;
//}
//void output(int[] mas)
//{
//    using (StreamWriter writer = new StreamWriter("result.txt"))
//    {
//        for (int i = 0; i < mas.Length; i++)
//        {
//            writer.WriteLine(mas[i]);
//        } 
//        writer.WriteLine($"max-{max}, min-{min}, avg-{avg}");
//    }
//}

//int[] mass = new int[10000];
//for (int i = 0; i < 10000; i++)
//{
//    mass[i] = random.Next(1, 151);
//}
//Thread thread1 = new Thread(() =>MaxNumber(mass));
//thread1.Start();

//Thread thread2 = new Thread(() => MinNumber(mass));
//thread2.Start();

//Thread thread3 = new Thread(() => AvgNumber(mass));
//thread3.Start();    

//Thread thread4 = new Thread(() => output(mass));
//thread4.Start();

//thread1.Join();
//thread2.Join();
//thread3.Join();
//thread4.Join();
//Console.WriteLine($"{max}, {min}, {avg}");
    