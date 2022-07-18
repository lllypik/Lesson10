using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите угол в формате АА.ВВ.СС (АА-градусы, ВВ - минуты, СС - секунды)");
                int degreesAngle = Convert.ToInt32 (Console.ReadLine ());
                int minutesAngle = Convert.ToInt32(Console.ReadLine());
                int secondsAngle = Convert.ToInt32(Console.ReadLine());

                angle = new Angle(degreesAngle, minutesAngle, secondsAngle);
            }
            while (angle.isCorrect == false);

            Console.WriteLine("Угол {0} град. {1} мин. {2} сек. соответствует углу в {3:00.00} рад.", angle.Degrees, angle.Minutes, angle.Seconds, angle.ToRadians());
            Console.ReadKey();
        }
    }
}
