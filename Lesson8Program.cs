// See https://aka.ms/new-console-template for more information
/*Запросить у пользователя год его рождения
Если год < 1991, то вывести сообщение, что он рожден в СССР
Если год >= 1991 вывести на экран каждый четный год до текущего*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваш год рождения");
        int yearOfBirth = Convert.ToInt32(Console.ReadLine());
        if (yearOfBirth < 1991)
        {
            Console.WriteLine("Вы рождены в СССР");
        }
        else
        {
            var date = DateTime.Now;
            var dateY = date.Year;
            int c = dateY % 2;
            if (c > 0)
            {
                Console.WriteLine("В таком случае, четный год до текущего = " + (dateY - 1));
            }
            else
            {
                Console.WriteLine("В таком случае, четный год до текущего = " + (dateY - 2));
            }
        }
    }
}