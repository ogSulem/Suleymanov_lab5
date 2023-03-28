using System.Runtime.CompilerServices;
using System.Text;
//one();
//two();
//three();
//four();
//five();
//six();
//seven();
//dopOne();
//dopTwo();
//dopThree();
//dopFour();
//dopFive();
//dopSix();
//dopSeven();
//dopEight();
//dopNine();
//dopTen();
//dopEleven();
//dopTwelve();
//dopThirteen();
//dopFourteen();
//dopFiveteen();
//dopSixteen();
//dopSeventeen();
//dopEightteen();
//dopNineteen();
//dopTwenty();
//dopTwentyOne();
void one()
{
    Console.WriteLine("Введите имена через пробел: ");
    string[] names = Console.ReadLine().Split();
    Console.WriteLine("Имена, стоящие до имени Маши по алфавиту: ");
    for (int i = 0; i < names.Length; i++)
    {
        if (string.Compare(names[i], "Маша") < 0) Console.WriteLine(names[i]);
    }
}

void two()
{
    Console.WriteLine("Введите строку: ");
    string s = Console.ReadLine() + ' ';
    string ss = "";
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] != ' ')
        {
            ss += s[i];
        }
        else
        {
            Console.WriteLine($"{ss} {ss.Length}");
            if (ss.Length == 4)
            {
                s = s.Remove(i - ss.Length, ss.Length).Insert(i - ss.Length, "love_is");
            }
            ss = "";
        }
    }
    Console.WriteLine(s);
}

void three()
{
    Console.WriteLine("Введите текст: ");
    string s = Console.ReadLine();
    Console.WriteLine("Введите количество символов, после которых нужно ставить '': ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = n; i < s.Length; i += n + 1)
    {
        s = s.Insert(i, "");
    }
    Console.WriteLine(s);
}

void four()
{
    Console.WriteLine("Введите предложение: ");
    string s = Console.ReadLine();
    string[] sWords = s.Split();
    string Long = sWords[0];
    string Short = sWords[0];
    foreach (string item in sWords)
    {
        if (item.Length > Long.Length) Long = item;
        if (item.Length < Short.Length) Short = item;
    }
    string result = "";
    for (int i = 0; i < Long.Length; i++)
    {
        result += Long + ", ";
    }
    for (int i = 0; i < Short.Length; i++)
    {
        result += Short + ", ";
    }
    result = result.Substring(0, result.Length - 2);
    Console.WriteLine(result);
}

void five()
{
    Console.WriteLine("Введите строку: ");
    string s = Console.ReadLine().ToLower();
    string[] words = s.Split();
    string[] uniqueWords = words.Distinct().ToArray();
    string result = string.Join(' ', uniqueWords);
    Console.WriteLine(result);
}

void six()
{
    StringBuilder s = new StringBuilder();
    while (true)
    {
        StringBuilder ss = new StringBuilder(Console.ReadLine());
        if (ss.ToString() == "") break;
        string[] sArray = ss.ToString().Split();
        int flag = 1;
        for (int i = 0; i < sArray.Length; i++)
        {
            if (flag == 1)
            {
                s.Append($"{sArray[i]} ");
                flag++;
            }
            else if (flag == 2)
            {
                StringBuilder sss = new StringBuilder();
                for (int j = sArray[i].Length - 1; j >= 0; j--)
                {
                    sss.Append(sArray[i][j]);
                }
                s.Append($"{sss} ");
                flag++;
            }
            else flag -= 2;
        }
        s.Remove(s.Length - 1, 1);
        s.Append(". ");
    }
    Console.WriteLine(s.ToString());
}

string sevenF(string text)
{
    string[] words = text.Split();
    StringBuilder result = new StringBuilder();
    string firstWord = words[0];
    for (int i = 0; i < words.Length; i++)
    {
        string first = words[i][0].ToString().ToLower();
        int flag = 1;
        for (int j = 0; j < words.Length; j++)
        {
            if (words[i] == words[j]) continue;
            string last1 = words[j][words[j].Length - 1].ToString().ToLower();
            if (first == last1) flag = 2;
        }
        if (string.Compare(firstWord, words[i]) > 0) firstWord = words[i];
        if (flag == 1)
        {
            firstWord = words[i];
            break;
        }
    }
    result.Append($"{firstWord} ");
    while (result.ToString().Split().Length != words.Length + 1)
    {
        string lastRes = result[result.Length - 2].ToString().ToLower();
        for (int i = 0; i < words.Length; i++)
        {
            string firstChar = words[i][0].ToString().ToLower();
            if (firstChar == lastRes)
            {
                result.Append($"{words[i]} ");
                break;
            }
        }
    }
    return result.ToString();
}
void seven()
{
    string input = "Киев Нью-Йорк Амстердам Вена Мельбурн";
    Console.WriteLine(sevenF(input));
}

void dopOne()
{
    string text = "Белая ворона летит выше остальных. Но остальные не видят" +
        " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    Console.WriteLine("Введите слово: ");
    string A = Console.ReadLine();
    string ss = "";
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] != '.')
        {
            ss += text[i];
        }
        else
        {
            if (ss.ToLower().Contains(A.ToLower()) == true)
            {
                string[] result = ss.Split();
                string s = "";
                for (int j = result.Length - 1; j >= 0; j--)
                {
                    s += result[j] + " ";
                }
                Console.WriteLine(s);
            }
            ss = "";
        }
    }
}
void dopTwo()
{
    string s = "14 голубей. 18 обезьян. 1 бродячий пес. 3 вороны. 4 школьника." +
        "14 волейболисток. 18 голов. 1 лошадь. 3 зебры. 4 девушки." +
        "14 лис. 18 берегов. 1 носок. 3 вала. 4 пальца";
    Console.Write("Введите число: ");
    string n = Console.ReadLine();
    string[] results = new string[0];
    string ss = "";
    for (int i = 0, j = 0; i < s.Length; i++)
    {
        if (s[i] != '.')
        {
            ss += s[i];
        }
        else
        {
            ss += s[i];
            if (ss.Contains(n))
            {
                Array.Resize(ref results, results.Length + 1);
                results[j] = ss;
                j++;
            }
            ss = "";
        }
    }
    Array.Sort(results);
    for (int i = results.Length - 1; i >= 0; i--) Console.WriteLine(results[i]);
}

void dopThree()
{
    string text = "Белая ворона летит выше остальных. Но остальные не видят" +
        " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    Console.Write("Введите слово: ");
    string A = Console.ReadLine();
    string ss = "";
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] != ' ')
        {
            ss += text[i];
        }
        else
        {
            if (ss.ToLower() == A.ToLower())
            {
                string right = "";
                for (int j = i + 1; text[j] != ' '; j++)
                {
                    right += text[j];
                }
                text = text.Remove(i + 1, right.Length + 1);
                text = text.Insert(i - ss.Length, right + ' ');
            }
            ss = "";
        }
    }
    Console.WriteLine(text);
}

void dopFour()
{
    string text = "Белая ворона летит выше остальных, но остальные не видят" +
        " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    Console.WriteLine("Предложения не содержащие запятых: ");
    string[] sentences = (' ' + text).Split('.');
    for (int i = 0; i < sentences.Length; i++)
    {
        if (sentences[i].Contains(',') == false) Console.WriteLine(sentences[i]);
    }
    Console.WriteLine("Количество слов в предложении: ");
    for (int i = 0; i < sentences.Length - 1; i++)
    {
        string[] words = sentences[i].Split();
        Console.WriteLine($"{sentences[i]} - {words.Length - 1}");
    }
}

void dopFive()
{
    string text = "Белая ворона летит выше остальных. Но остальные не видят" +
        " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    Console.Write("Введите N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    char[] seps = { ' ', '.', ',' };
    string[] words = text.Split(seps);
    int result = 0;
    foreach (string word in words) if (word.Length <= n && word != "") result++;
    Console.WriteLine($"Слов в тексте, длина которых не превышает {n} = {result}");
}

void dopSix()
{
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
        " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    Console.Write("Введите N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] sentences = text.Split('.');
    Console.WriteLine($"Предложения содержащие {n} слов: ");
    foreach (string sentence in sentences)
    {
        string[] words = sentence.Split();
        if (words.Length == n + 1) Console.WriteLine(sentence);
    }
}

void dopSeven()
{
    string text = "Для достижения данных целей необходимо выполнить следующие " +
        "задачи: - проанализировать основные показатели " +
        "экономического развития России; - изучить внешнеэкономическую " +
        "деятельность России и ее участие в международных экономических " +
        "организациях; - определить тенденции в мировой экономике, " +
        "влияющие на место России в ней; - сформулировать рекомендации " +
        "по улучшению позиции России в мировом хозяйстве.";
    char[] seps = { ':', ';' };
    string[] sents = text.Split(seps);
    Console.WriteLine("Предложение, начинающиеся с тире: ");
    foreach (string sent in sents)
    {
        if (sent[0] == '-' || sent[1] == '-') Console.WriteLine(sent);
    }
}

void dopEight()
{
    string text = "Найти и заменить слова «ноль», «один» ...«девять», цифрами от 0 до 9;";
    string[] seps = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
    for (int i = 0; i < 10; i++)
    {
        text = text.Replace(seps[i], Convert.ToString(i));
    }
    Console.WriteLine(text);
}

void dopNine()
{
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
       " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    char[] seps = { '.', ' ' };
    string[] words = text.Split(seps);
    string maxWord = words[0];
    foreach (string word in words) maxWord = (maxWord.Length > word.Length) ? maxWord : word;
    Console.Write($"Слово {maxWord} встречается в тексте {text.Split(maxWord).Length - 1} раз");
}

void dopTen()
{
    char[] glas = { 'а', 'о', 'е', 'ё', 'у', 'и', 'ю', 'я', 'ы', 'э' };
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
       " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    char[] seps = { '.', ' ' };
    string[] words = text.Split(seps);
    string wordMaxGlas = words[0];
    foreach (string word in words) wordMaxGlas = (word.Split(glas).Length - 1 > wordMaxGlas.Split(glas).Length - 1) ? word : wordMaxGlas;
    Console.Write($"Слово {wordMaxGlas} встреилось в тексте {text.Split(wordMaxGlas).Length - 1} раз");
}

void dopEleven()
{
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
       " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    string[] repeats = new string[0];
    string s = "";
    for (int i = 0, j = 0; i < text.Length - 1; i++)
    {
        if (text[i] == text[i + 1])
        {
            s += text[i];
        }
        else
        {
            if (s != "")
            {
                s += s[0];
                Array.Resize(ref repeats, repeats.Length + 1);
                repeats[j] = s;
                j++;
                s = "";
            }
        }
    }
    Console.WriteLine($"Количество повторений в тексте: {repeats.Length}\n" +
        $"Количество букв в повторении: ");
    foreach (string repeat in repeats) Console.WriteLine($"{repeat} - {repeat.Length}");
}

void dopTwelve()
{
    string text = ' ' + "Белая ворона летит выше остальных! Но остальные не видят" +
       " ее и так и считают себя лучшими! Ворона умная и глупая одновременно?";
    string[] words = text.Split();
    string[] sens = new string[0];
    string ss = "";
    for (int i = 0, j = 0; i < words.Length; i++)
    {
        if (words[i].Contains('?') == false && words[i].Contains('.') == false && words[i].Contains('!') == false)
        {
            ss += words[i] + ' ';
        }
        else
        {
            ss += words[i];
            Array.Resize(ref sens, sens.Length + 1);
            sens[j] = ss;
            j++;
            ss = "";
        }
    }
    foreach (string sen in sens) if (sen.Contains('?')) Console.WriteLine(sen);
    foreach (string sen in sens) if (sen.Contains('!')) Console.WriteLine(sen);
}

void dopThirteen()
{
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
       " ее и так и считают себя лучшими. Ворона умная и ворона глупая одновременно. ";
    Console.Write("Введите слово: ");
    string input = Console.ReadLine();
    string[] sens = text.Split('.');
    for (int i = 0; i < sens.Length - 1; i++)
    {
        Console.Write($"{sens[i]}. {sens[i].ToLower().Split(input.ToLower()).Length - 1}.");
    }
}

void dopFourteen()
{
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
       " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    string[] sens = text.Split('.');
    Array.Sort(sens);
    for (int i = sens.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(sens[i]);
    }
}

void dopFiveteen()
{
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
     " ее и так и считают себя лучшими. А лучших здесь нет. Ворона умная и глупая одновременно.";
    string[] sens = text.Split('.');
    for (int i = 0; i < sens.Length-1; i++)
    {
        string[] words = sens[i].Split();
        if (words[1].Length == 1) Console.WriteLine(sens[i]);
    }
    for (int i = 0; i < sens.Length - 1; i++)
    {
        string[] words = sens[i].Split();
        if (words[1].Length != 1) Console.WriteLine(sens[i]);
    }
}

void dopSixteen()
{
    string text = " Белая ворона летит выше остальных. Но остальные не видят" +
      " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    Console.Write("Введите слово: ");
    string A = Console.ReadLine();
    string[] sens = text.Split('.');
    foreach (string sen in sens)
    {
        if (sen.ToLower().Contains(A.ToLower()))
        {
            string[] words = sen.Split();
            string s = words[1];
            words[1] = words[words.Length - 1];
            words[words.Length - 1] = s + '.';
            foreach (string word in words) Console.Write(word + ' ');
        }
    }
}

void dopSeventeen()
{
    char[] puncs = { ',', ';', '-', ':', '(', ')' };
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
      " ее и так и считают себя лучшими. Ворона умная и глупая,  одновременно.";
    string[] sens = text.Split('.');
    string result = sens[0];
    foreach (string sen in sens) result = (result.Split(puncs).Length - 1 > sen.Split(puncs).Length - 1) ? result : sen;
    Console.WriteLine(result);
}

void dopEightteen()
{
    string text = ' ' + "Белая ворона летит выше остальных! Но остальные не видят" +
      " ее и так и считают себя лучшими! Ворона умная и глупая одновременно?";
    text = text.Replace(".", " точка");
    text = text.Replace("?", " вопросительный знак");
    text = text.Replace("!", " восклицательный знак");
    text = text.Replace(",", " запятая");
    Console.WriteLine(text);
}

void dopNineteen()
{

    string text = "Белая ворона летит выше остальных. Но остальные не видят" +
        " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    Console.Write("Введите N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    char[] seps = { ' ', '.', ',' };
    string[] words = text.Split(seps);
    int result = 0;
    foreach (string word in words) if (word.Length >= n && word != "") result++;
    Console.WriteLine($"Слов в тексте, длина которых не менее {n} = {result}");
}

void dopTwenty()
{
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
       " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    char[] seps = { '.', ' ' };
    string[] words = text.Split(seps);
    string minWord = words[0];
    foreach (string word in words) minWord = (minWord.Length < word.Length) ? minWord : word;
    Console.Write($"Слово {minWord} встречается в тексте {text.Split(minWord).Length - 1} раз");
}

void dopTwentyOne()
{
    string text = ' ' + "Белая ворона летит выше остальных. Но остальные не видят" +
      " ее и так и считают себя лучшими. Ворона умная и глупая одновременно.";
    char[] chars = new char[0];
    for (int i = 0, j = 0; i < text.Length; i++)
    {
        if (chars.Contains(text.ToLower()[i]) == false)
        {
            Array.Resize(ref chars, chars.Length + 1);
            chars[j] = text.ToLower()[i];
            j++;
        } 
    }
    foreach (char ch in chars) Console.WriteLine($"{ch} - {text.ToLower().Split(ch).Length - 1}");
}