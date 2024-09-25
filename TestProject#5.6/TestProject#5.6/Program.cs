using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_5._6
{
    internal class Program
    {
        static void PrintUserInfo((string Name, string SurName, int Age, string[] Pets, string[] FavoriteColors) User)
        { }
        static public(string Name, string SurName, int Age, string[] Pets, string[] FavoriteColors) CreateDataUser()
        {
            int ageUser = 0;
            string ageValue = string.Empty;
            string HasPets = "Нет";
            (string Name, string SurName, int Age, string[] Pets, string[] FavoriteColors) User;
            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            User.SurName = Console.ReadLine();

            do {
                Console.WriteLine("Введите возраст: ");
                ageValue = Console.ReadLine();
            }
            while (int.TryParse(ageValue, out ageUser) && ageUser > 0);

            User.Age = ageUser;

            Console.WriteLine("Есть ли питомцы? ");
            HasPets = Console.ReadLine();

            switch (HasPets)
            {
                case "Да":

                    break;
                case "Нет":

                    break;
            }

            return User;
        }
        static void Main(string[] args)
        {
            (string Name, string SurName, int Age, string[] Pets, string[] FavoriteColors) User = CreateDataUser();
            PrintUserInfo(User);
        }
    }
}
