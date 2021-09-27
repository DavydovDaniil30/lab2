using System;

namespace ConsoleApp6
{
    class User

    {

        public string login; // индекс

        public string name;     // Страна

        public string surname;     // город

        public string age;     // улица

        private DateTime date = DateTime.Today;





        public void GetInfo()

        {
            Console.WriteLine($"login: {login} \nname: {name} \nsurname: {surname} \nage: {age} \ndate of registrarion: {date.ToString("D")}\n");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            User user = new User();

            user.login = "note4x0211@gmail.com";

            user.name = "Daniil";

            user.surname = "Davydov";

            user.age = "18";

            user.GetInfo();

            Console.ReadKey();

        }

    }
}
