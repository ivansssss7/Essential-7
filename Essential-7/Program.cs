using Essential_7;
using System;
using System.Collections.Generic;

namespace Essential7;

class Program
{
    static void Main(string[] args)
    {
        Train[] trains = new Train[8]; 

        for (int i = 0; i < trains.Length; i++)
        {
            Train train = new Train();

            Console.WriteLine($"Введіть дані для {i + 1}-го поїзда:");
            Console.Write("Назва пункту призначення: ");
            train.Destination = Console.ReadLine();

            Console.Write("Номер поїзда: ");
            train.TrainNumber = int.Parse(Console.ReadLine());

            Console.Write("Час відправлення (у форматі HH:mm): ");
            train.DepartureTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);

            trains[i] = train;
        }

        Array.Sort(trains);

        Console.Write("Введіть номер поїзда для отримання інформації: ");
        int searchNumber = int.Parse(Console.ReadLine());

        bool found = false;
        foreach (var train in trains)
        {
            if (train.TrainNumber == searchNumber)
            {
                Console.WriteLine($"Інформація про поїзд {searchNumber}:");
                Console.WriteLine($"Назва пункту призначення: {train.Destination}");
                Console.WriteLine($"Час відправлення: {train.DepartureTime.ToString("HH:mm")}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Поїзд з номером {searchNumber} не знайдено.");
        }
    }
}