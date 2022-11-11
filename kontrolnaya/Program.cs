using System;
 
public class Example
{
    public static void Main()
    {
        //Собираем исходный массив
        string[] array = new string[]{};        
        array = array.Append("dfgfd").ToArray();
        array = array.Append("12").ToArray();
        array = array.Append("sss").ToArray();
        array = array.Append("3453").ToArray();        
        array = array.Append("35d").ToArray();
           
        //Выводим исходный массив
        Console.Write("['");
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.Write(array[i] + "', '");
        }
        Console.Write(array[array.Length-1] + "'] -> ");

        //Собираем результирующий массив
        string[] result = new string[]{};
        for (int i = 0; i <= array.Length-1; i++)
        {
            if (array[i].Length <= 3)
            {
                result = result.Append(array[i]).ToArray();
            }
        }

        //Выводим результат
        Console.Write("['");
        for (int i = 0; i < result.Length-1; i++)
        {
            Console.Write(result[i] + "', '");
        }
        Console.Write(result[result.Length-1] + "']");
    }
}