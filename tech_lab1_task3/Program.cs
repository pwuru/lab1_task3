namespace tech_lab1_task3
{
    public class Logic
    {
        public static int CountLetters(string str)
        {
            int count = 0;
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }
            str = str.ToLower();
            int groupSize = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1]) 
                {
                    groupSize++;
                }
                else
                {
                    if (groupSize > 1)
                    {
                        count += groupSize;
                    }
                    groupSize = 1; 
                }
            }
            if (groupSize > 1)
            {
                count += groupSize;
            }
            return count;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string sentence = Console.ReadLine();

            int count = Logic.CountLetters(sentence);

            if (count == -1)
            {
                Console.WriteLine("Введена пустая строка ");
            }
            else
            {
                Console.WriteLine("Количество одинаковых соседних букв: " + count);
            }
        }
    }
}
