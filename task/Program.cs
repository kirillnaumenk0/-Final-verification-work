/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */
class Program
{
    static void WriteArray(string[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            string res = string.Empty;
            res = array[i];
            if (res.Length < 4)
            {
                Console.Write(array[i]);
                if (i < array.Length - 2)
                {
                    Console.Write(",");
                }
            }
        }
    }
    static void Main(string[] args)
    {
        string[] array = new string[0];
        while (true)
        {
            Console.WriteLine("Введите значение массива, либо команду - end для завершения программы");
            string meaning = Console.ReadLine();
            if (meaning != "end")
            {
                string[] newArray = array;
                array = new string[array.Length + 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    array[i] = newArray[i];
                }
                array[array.Length - 1] = meaning;
            }
            else
            {
                break;
            }
        }
        WriteArray(array);
    }

}