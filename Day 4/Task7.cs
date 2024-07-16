using System;
    public class Program{
        public static void Main(string[] args)
        {
            Console.Write("Enter the Sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter a word to find: ");
            string word = Console.ReadLine();
            int index = sentence.IndexOf(word);
            if (index != -1){
                Console.WriteLine("The word {0} is found at index {1} in the sentence.",word,index);
            }
            else{
                Console.WriteLine("The word {0} is not found in the sentence.",word);
            }
        }
    }