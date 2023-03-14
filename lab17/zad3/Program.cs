using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace p2
{
    class Program
    {
        static string pathfile = @"TF1.txt";
        static string pathfile2 = @"TF1Copy.txt";
        static void WriteData()
        {
            bool check = true;
            FileStream file = new FileStream(pathfile, FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file, Encoding.UTF8);
            while (check == true)
            {
                Console.WriteLine("Введите строку для записи в файл:");
                string str = Console.ReadLine();
                writer.WriteLine(str);
                Console.WriteLine("Еще раз ввести? y - Yes, n - No");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                {
                    check = false;
                }
            }
            Console.WriteLine("Данные успешно внесены!!!");
            writer.Close();
            file.Close();
        }
        static void CountSTR()
        {
            int count = System.IO.File.ReadAllLines(pathfile).Length;
            Console.WriteLine("Количество строк в файле:=" + count);
        }
        static void CountElemStr()
        {
            int count = 0;
            FileStream file = new FileStream(pathfile, FileMode.OpenOrCreate);
            StreamReader fs = new StreamReader(file);
            string str;
            while ((str = fs.ReadLine()) != null)
            {
                Console.WriteLine(str);
                count += str.Length + 1;
            }
            fs.Close();
            Console.WriteLine("В файле символов {0}", count);
        }
        static void VivodStr()
        {
            List<string> list = new List<string>();
            Console.WriteLine("Введите с которой строки хотите вывести s1: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите по которую строку хотите вывести s2: ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            using (FileStream file = new FileStream(pathfile, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    while (!reader.EndOfStream)
                    {
                        list.Add(reader.ReadLine());
                    }
                    if (list.Count != 0)
                    {
                        for (int i = s1 - 1; i <= s2 - 1; i++)
                        {
                            Console.WriteLine(i + 1 + ". " + list[i]);
                        }
                    }
                    else
                        Console.WriteLine("Список пуст!!!");
                }
            }
        }
        static void DeliteStr()
        {

            string[] lines = File.ReadAllLines(@"TF1.txt");

            FileStream newfile = new FileStream(@"TF1Copy.txt", FileMode.Create);
            StreamWriter newsw = new StreamWriter(newfile);
            for (int i = 0; i < lines.Length - 1; i++)
            {
                newsw.WriteLine(lines[i]);
            }
            newsw.Close();
            newfile.Close();
        }
        static void GivenChar()
        {
            Console.WriteLine("Все строки начинающиеся с буквы:");
            char ch = char.Parse(Console.ReadLine());
            string[] lines = File.ReadAllLines(@"TF1.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string temp = lines[1];
                if (temp[0] == ch)
                {
                    Console.WriteLine(lines[i]);
                }
            }
        }
        static void DlinaStr()
        {
            StreamReader file = new StreamReader("TF1.txt");
            string maxString = "", tmpString;
            while ((tmpString = file.ReadLine()) != null)
            {
                if (tmpString.Length > maxString.Length)
                    maxString = tmpString;
            }
            Console.WriteLine("Cамая длинная строчка: {0}", maxString);
        }
        static void Overwrite()
        {
            string[] lines = File.ReadAllLines(@"TF1.txt");
            FileStream newfile = new FileStream(@"TF1Copy.txt", FileMode.Create);
            StreamWriter newsw = new StreamWriter(newfile);
            Console.WriteLine("Значения нового файла:");
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                newsw.WriteLine(lines[i]);
                Console.WriteLine(lines[i]);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Добавить строку в файл:");
            Console.WriteLine("2 - Постчитать количестов строк в файле");
            Console.WriteLine("3 - Посчитать количество символов в каждой строке файла");
            Console.WriteLine("4 - удалить последнюю строку из файла, результат записать в новый файл ");
            Console.WriteLine("5 - Вывести на экран строку с s1 по s2");
            Console.WriteLine("6 - Найти длину самой длинной строки и вывести ее на экран");
            Console.WriteLine("7 - Вывести на экран все строки начинающиеся с заданной буквы");
            Console.WriteLine("8 - Порядок строк во втором файле должен быть обратным по отношению к порядку строк в заданном файле.");
            Console.WriteLine("9 - Выйти из программы ");
            bool n = true;
            while (n == true)
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1: WriteData(); break;
                    case 2: CountSTR(); break;
                    case 3: CountElemStr(); break;
                    case 4: DeliteStr(); break;
                    case 5: VivodStr(); break;
                    case 6: DlinaStr(); break;
                    case 7: GivenChar(); break;
                    case 8: Overwrite(); break;
                    case 9: n = false; break;

                    default:
                        Console.WriteLine("Нет такого пункта ");
                        break;
                }
            }
        }
    }
}
