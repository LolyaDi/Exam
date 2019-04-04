using System;
using StorageSystem.Services;
using StorageSystem.Models;

namespace StorageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageService storage = new StorageService();

            KeyEvent keyEvent = new KeyEvent();

            ConsoleKeyInfo key;

            keyEvent.KeyPressed += (sender, e) =>
            {
                char keyPressed = e.key.KeyChar;

                if (!(e.key.KeyChar == Convert.ToChar(ConsoleKey.Enter)))
                {
                    e.Handled = true;
                }
                else
                {
                    Console.WriteLine("Введите название товара:");
                    string name = Console.ReadLine();
                    Product product = new Product()
                    {
                        Name = name
                    };

                    storage.AddProduct(product);
                }
            };

            Console.WriteLine("Нажмите enter для добавления товара.");
            while (true)
            {
                key = Console.ReadKey(true);

                keyEvent.OnKeyPressed(key);
            }

        }
    }
}
