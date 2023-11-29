using System;
using System.Collections.Generic;

namespace Statistics
{
    internal class Program
    {
        private static string text;
        private static Dictionary<string, int> wordCount;

        static void Main(string[] args)
        {
            Console.WriteLine("ПРЕДУПРЕЖДАЮ!!!\nИстория написана через чат GPT, чисто в развлекательных целях, и оно не намерено никого оскорбить");
            Console.WriteLine("Если хотите продолжить и прочесть историю, нажмите (y). А если нет, то (n)");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "y")
            {
                text = GetSampleText();
                wordCount = CountWords(text);
                DisplayStatistics(wordCount);
                Console.WriteLine();
                DisplayFullText();

                Console.WriteLine("\n\nЕсли вам понравилась истроия и вы хотите продолжение, то попросите у автора, тоесть у Айдына и его помощника-секретаря GPT-тян, он напишет вам такой шедевр, что вы даже не представляете");
            }
            else if (userInput.ToLower() == "n")
            {
                text = GetSampleText();
                wordCount = CountWords(text);
                DisplayStatistics(wordCount);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Завершение программы.");
            }
        }

        static string GetSampleText()
        {
            return "Берик и Нурасыл, два лучших друга, были настоящими братьями души. Их связь была так крепкой, что они могли читать друг друга как открытую книгу. Но их страсть к чему-то общему, кроме дружбы, выражалась в безусловной любви к донеру." +
                "\"Биг Донер\" стал местом, где они находили утешение в трудные моменты и праздновали радостные. Их любовь к этому великолепному блюду была настолько глубокой, что они иногда шутили, будто донер - единственная и непреходящая любовь их жизни." +
                "Однажды, когда в их жизни появилось недопонимание, вызванное обычной жизненной суетой, они поняли, что в их мире ничто не важнее, чем вкусный донер. Этот простой факт сблизил их еще больше." +
                "Они стали частыми гостями в \"Биг Донере\", делясь не только этим великолепным блюдом, но и своими радостями и заботами. Их дружба была такой прочной, что они осознали, что в жизни нет нужды в какой-то другой, чем дружба, страсти." +
                "Так проходили дни, наполненные весельем и приключениями, и каждый знал, что когда есть друг, и вкусный донер, мир становится ярче и прекраснее. Их история была историей необычайной дружбы, построенной на простых радостях и общих интересах.";
        }

        static Dictionary<string, int> CountWords(string text)
        {
            string[] words = text.Split(new[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string cleanedWord = word.ToLower();
                if (wordCount.ContainsKey(cleanedWord))
                {
                    wordCount[cleanedWord]++;
                }
                else
                {
                    wordCount[cleanedWord] = 1;
                }
            }

            return wordCount;
        }

        static void DisplayFullText()
        {
            Console.WriteLine("Текст:\n");
            Console.WriteLine(text + "\n");
        }

        static void DisplayStatistics(Dictionary<string, int> wordCount)
        {
            Console.WriteLine("Слово\t\tКоличество");
            Console.WriteLine("=====================");

            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
            }
        }
    }
}
