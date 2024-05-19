using Game.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace GameGuessTheNumber
{
    internal static class Program
    {
        static void Main()
        {
            var settings = new Settings();
            var consoleReader = new ConsoleReader();
            var textValidator = new TextValidator();
            var Randomizer = new Randomizer();
            var consoleWriter = new ConsoleWriter();
            int PCNumber;
            int UserNumber;
            string UserAnswer;
            int UserAttempts = 0;
            string TextVariant;

            settings.minValue = 0;
            settings.maxValue = 5;
            settings.maxAttempts = 3;

            PCNumber = Randomizer.RandomNumber(settings.minValue, settings.maxValue);

            consoleWriter.WriteToConsole("Начало игры \"Угадай число\". Попробуй угадать число, которое я загадал.");
            consoleWriter.WriteToConsole($"Число лежит в диапазоне от {settings.minValue} до {settings.maxValue}.");
            consoleWriter.WriteToConsole($"Количество попыток: {settings.maxAttempts}");

            while (UserAttempts < settings.maxAttempts)
            {
                consoleWriter.WriteToConsole("Напиши число");

                UserAnswer = consoleReader.Read();

                if (!textValidator.IsConvertableToInt(UserAnswer))
                {
                    consoleWriter.WriteToConsole("Необходимо ввести число");
                }
                else
                {
                    UserNumber = Int32.Parse(UserAnswer);

                    UserAttempts++;

                    if (PCNumber == UserNumber)
                    {
                        consoleWriter.WriteToConsole("Угадал, красава!");
                        break;
                    }
                    else
                    {
                        if (PCNumber < UserNumber)
                        {
                            TextVariant = "меньше";
                        }
                        else
                        {
                            TextVariant = "больше";
                        }
                        consoleWriter.WriteToConsole($"Не угадал. Загаданное число {TextVariant}.");
                        consoleWriter.WriteToConsole($"Осталось попыток: {settings.maxAttempts - UserAttempts}.");
                    }
                }


            }
        }
    }
}
