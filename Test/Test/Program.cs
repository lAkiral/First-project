using System;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Тест на мудака");
            Console.WriteLine("Выберите вариант из предложенных. На кого похожа пищуха?");
            Console.WriteLine("1. на мою бабушку");
            Console.WriteLine("2. на неведомую йобанную хуйню");
            Console.WriteLine("3. на мелкое животнама");
            string text2 = Console.ReadLine();
            int xx = Convert.ToInt32(text2);
            switch (xx)
            {
                case 1:
                    Console.WriteLine("хуйня ответ");
                    break;
                case 2:
                    Console.WriteLine("сам ты хуйня");
                    break;
                case 3:
                    Console.WriteLine("БИНГО!");
                    count++;
                    break;
                default:
                    Console.WriteLine("какое ты жалкое ничтожество, иди нахуй, я тебя не звал!");
                    break;
            }
            Console.ReadKey();
            Console.WriteLine("Выберите вариант из предложенных. Этот родственник домашней козы обитает среди гор?");
            Console.WriteLine("1. Дэвил");
            Console.WriteLine("2. Дикий горный козел");
            Console.WriteLine("3. Алексей");
            string text3 = Console.ReadLine();
            int xxx = Convert.ToInt32(text3);
            switch (xxx)
            {
                case 1:
                    Console.WriteLine("Почти, но не то");
                    break;
                case 2:
                    Console.WriteLine("И это правильный, мать твою, ответ!!");
                    count++;
                    break;
                case 3:
                    Console.WriteLine("Хотелось бы, но нет");
                    break;
                default:
                    Console.WriteLine("какое ты жалкое ничтожество, иди нахуй, я тебя не звал!");
                    break;
            }
            Console.ReadKey();

            Console.WriteLine("Выберите вариант из предложенных. Правда ли, что в сильную жару или град, форель можно поймать руками?");
            Console.WriteLine("1. Пиздежь");
            Console.WriteLine("2. Сто пуд, это правда");
            string text4 = Console.ReadLine();
            int xxxx = Convert.ToInt32(text4);
            switch (xxxx)
            {
                case 1:
                    Console.WriteLine("А вот это абсолютно неправильный ответ!");
                    break;
                case 2:
                    Console.WriteLine("А ты случаем не Онотолий Вассерман? Это верно!");
                    count++;
                    break;
                default:
                    Console.WriteLine("какое ты жалкое ничтожество, иди нахуй, я тебя не звал!");
                    break;
            }
            Console.ReadKey();
            Console.WriteLine("Выберите вариант из предложенных. Какой римский император назначил сенатором своего коня?");
            Console.WriteLine("1. Юлиан Цезарионович");
            Console.WriteLine("2. Хуигула");
            Console.WriteLine("3. Нейрон");
            string text5 = Console.ReadLine();
            int xxxxx = Convert.ToInt32(text5);
            switch (xxxxx)
            {
                case 1:
                    Console.WriteLine("А вот и нетушки!");
                    break;
                case 2:
                    Console.WriteLine("И это правильный, мать твою, ответ!!");
                    count++;
                    break;
                case 3:
                    Console.WriteLine("Лох, пидр! Ответ неверен!");
                    break;
                default:
                    Console.WriteLine("какое ты жалкое ничтожество, иди нахуй, я тебя не звал!");
                    break;

            }
            Console.WriteLine($"Привильных ответов: {count}");
            //$ - позволяет вписывать в строку все переменные и т.д.
            Console.ReadKey();

            Console.WriteLine("Привильных ответов: {0}", count);
            Console.WriteLine("Привильных ответов:" + count);
            //старые варианты "$"

            Console.WriteLine("Решите пример: 5 + 2");
            string text6 = Console.ReadLine();
            int x6 = Convert.ToInt32(text6);
            if (x6 == 7) 
            {
                Console.WriteLine("Это правильный ответ");
            }
            else
            {
                Console.WriteLine("Перерешай, ответ - говно");
            }
            Console.ReadKey();
            // не очень понятно как присваюваются переменные строк 110 и 111

            Console.WriteLine("Решите пример: 2 + 2 * 2");
            string text7 = Console.ReadLine();
            int x7 = Convert.ToInt32(text7);
            if (x7 == 6)
            {
                Console.WriteLine("Угадал!");
            }    
            
            else
            {
                Console.WriteLine("Неверно, учитывая то, что это уровень первого класса!");
            }
            Console.ReadKey();

            Console.WriteLine("Угадайте или решите уравнение: 11 * 11");
            string text8 = Console.ReadLine();
            int x8 = Convert.ToInt32(text8);
            if (x8 == 121) 
            {
                Console.WriteLine("Йопта! Да ты умница");
            }
            else
            {
                Console.WriteLine("Ты туп, как полено! Неверно!");
            }
            Console.WriteLine($"Привильных ответов: {count}");
            Console.ReadKey();

        }
    }
}
