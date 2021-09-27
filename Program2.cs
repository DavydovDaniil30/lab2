using System;

namespace ConsoleApp5
class Book

{
    public class Title
    {

        public string title;

        public void Show()
        {

            if (title == "")
            {
                title = "Вели­кий Гэтсби";
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{title}\n\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{title}\n\n");
            }
        }
    }

    public class Author
    {

        public string author;

        public void Show()
        {

            if (author == "")
            {
                author = "Фрэнсис Скотт Фитц­д­же­ральд";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Книга написана автором {author}\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Книга написана автором {author}\n");
            }
        }
    }
    public class Content
    {

        public string content;

        public void Show()
        {
            if (content == "")
            {
                content = "Интересная история";
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Книга написана о {content}\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Книга написана о {content}\n");
                Console.ResetColor();
            }
        }
    }
}

class Program

{
    static void Main(string[] args)

    {

        Book.Title t = new Book.Title();
        Book.Author a = new Book.Author();
        Book.Content c = new Book.Content();

        Console.WriteLine("Введите название вашей книги");
        t.title = Console.ReadLine();
        Console.WriteLine("Введите имя автора");
        a.author = Console.ReadLine();
        Console.WriteLine("Введите содержимое");
        c.content = Console.ReadLine();
        Console.WriteLine("Ваша книга готова!\n");
        t.Show();
        a.Show();
        c.Show();
    }
}

}