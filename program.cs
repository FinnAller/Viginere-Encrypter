//Author: Joelbu
using System;
class Program
{
    const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";
    static void Main(string[] args)
    {
        Console.Title = "Viginere Encryper";
        while (true)
        {
            try
            {
                Console.Clear();
                Console.Write("Enter string: ");
                string input = Console.ReadLine().ToLower();
                Console.Write("Enter key: ");
                string key = Console.ReadLine().ToLower();
                int count = 0;
                string encoded = "";
                for (int i = 0; i < input.Length; i++)
                {
                    encoded += GetString((GetIndex(input[i]) + GetIndex(key[count])) % 26); //MATH
                    count++;
                    if (count == key.Length)
                    {
                        count = 0;
                    }
                }
                Console.Clear();
                Console.WriteLine($"Input: {input}");
                Console.WriteLine($"Encoded String: {encoded}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :(");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
    static int GetIndex(char character)
    {
        for (int i = 0; i < ALPHABET.Length; i++)
        {
            if (character == ALPHABET[i])
            {
                return i;
            }
        }
        return -1;
    }
    static string GetString(int index)
    {
        return Convert.ToString(ALPHABET[index]);
    }
}
