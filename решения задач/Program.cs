// Zadacha 1
// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
/*class Program
{
   static void Main()
  {
    // Задаем двумерный массив символов
    char[,] charMatrix =new char[,] {{'H','o','m','e','w','o','r','k'}};
    string str = ""; // Создаем строку из символов массива

      for(int i = 0; i < charMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
           str += charMatrix[i,j];
        }
    }
     
     Console.WriteLine(str); // Выводим полученную строчку


   }

} 
  */


//ZADACHA 2:
// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

/*class Program
{
    static void Main()
    {
        string inputString = "HelLo WoRld GB"; // Исходная строка

        string result = ""; // Результирующая строка

        foreach (char c in inputString)
        {
            if (char.IsUpper(c)) // Проверяем, является ли символ заглавной буквой
            {
                result += char.ToLower(c); // Заменяем заглавную букву на строчную 
            }
            else
            {
                result += c; // Если символ не является заглавной, добавляем его к резул-ей строке без изменений
            }
        }

        Console.WriteLine(result);  // Выводим результат
    }
*/

   
//ZADACHA 3
//Задайте произвольную строку. Выясните, является ли она палиндромом.



class Program
{
    static void Main()
    {
      string text = "Я вчера сходила в гости"  ;
       char[] obrtext = text.ToCharArray();
       Array.Reverse(obrtext);
       string finaltext = new string(obrtext);
            if(text==finaltext)  //проверка текста на равность к перевернутому тексту
            {
                Console.WriteLine("Данная запись является палиндромом");
            }
            if (text!=finaltext)
            {
                Console.WriteLine("Данная запись не является палиндромом");
            }
    }
}  