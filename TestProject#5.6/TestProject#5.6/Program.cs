using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_5._6
{
    class Program
    {
        const string PETNAME = "Pet";

        static bool IsCheckNumber(string Value, out int Number)
        {
            if (int.TryParse(Value, out int numericValue))
            {
                if (numericValue > 0)
                {
                    Number = numericValue;
                    return false;
                }
                else
                    {
                        Number = 0;
                        return true; 
                    }
            }
            else
            {
                Number = 0;
                return true;
            }

        }

        static void PrintUserInfo((string Name, string SurName, int Age, string[] Pets, string[] FavoriteColors) User)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ИНФОРМАЦИЯ О ПОЛЬЗОВАТЕЛЕ:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Имя: " + User.Name);
            Console.WriteLine("Фамилия: " + User.SurName);
            Console.WriteLine($"Возраст: {User.Age} лет");
            Console.WriteLine("Любимые питомцы:");
            if ((User.Pets == null) || (User.Pets.Length == 0))
            {
                Console.WriteLine("\t - любимых питомцев нет");
            }
            else
            {
                for (int i = 0; i < User.Pets.Length; i++)
                    Console.WriteLine($"\t - питомец {i + 1}: {User.Pets[i]} ");
            }
            Console.WriteLine("Любимые цвета:");
            if ((User.FavoriteColors == null) || (User.FavoriteColors.Length == 0))
            {
                Console.WriteLine("\t - любимых цветов нет");
            }
            else
            {
                for (int i = 0; i < User.FavoriteColors.Length; i++)
                    Console.WriteLine($"\t - цвет {i + 1}: {User.FavoriteColors[i]} ");
            }
        }

        static public string[] CreateColors(int CountColors)
        {
            string[] Colors = new string[CountColors];
            for (int i = 0; i < CountColors; i++)
            {
                Console.WriteLine($"Введите название {i + 1}-ого цвета: ");
                Colors[i] = Console.ReadLine();
            }
            return Colors;
        }
        static public string[] CreatePets()
        {
            int countPets;
            string namePet;
            int indexPet = 0;
            string ConsoleString;

            do
            {
                Console.WriteLine("Есть ли потомец? /n 1 - да, 2 - нет (любое другое значение будет считаться за 'нет')");
                ConsoleString = Console.ReadLine();
            }
            while (IsCheckNumber(ConsoleString, out indexPet));

            if (indexPet == 1) {
                do
                {
                    Console.WriteLine("Введите количество питомцев:");
                }
                while (IsCheckNumber(Console.ReadLine(), out countPets));

                string[] Pets = new string[countPets];
                for (int i = 0; i < countPets; i++)
                {
                    namePet = PETNAME + " " + i.ToString();
                    Pets[i] = namePet;
                }
                return Pets;
            }
            else
                return null;
        }
        static public(string Name, string SurName, int Age, string[] Pets, string[] FavoriteColors) CreateDataUser()
        {
            string Name = string.Empty;
            string SurName = string.Empty;
            int Age = 0;
            string[] Pets;
            string[] Colors;
            int ageUser = 0;
            string ageValue = string.Empty;
            int countColors = 0;
            Console.WriteLine("Введите имя: ");
            Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            SurName = Console.ReadLine();

            do
            {
                Console.WriteLine("Введите возраст: ");
                ageValue = Console.ReadLine();
            }
            while (IsCheckNumber(ageValue, out ageUser));

            Age = ageUser;

            Pets = CreatePets();

            do {
                Console.WriteLine("Введите количество любимых цветов:");
            }
            while (IsCheckNumber(Console.ReadLine(), out countColors) && countColors > 0);

            Colors = CreateColors(countColors);

            return (Name, SurName, Age, Pets, Colors);
        }
        static void Main(string[] args)
        {
            (string Name, string SurName, int Age, string[] Pets, string[] FavoriteColors) User = CreateDataUser();
            Console.WriteLine("\n");
            PrintUserInfo(User);
            Console.ReadKey();
        }
    }
}
