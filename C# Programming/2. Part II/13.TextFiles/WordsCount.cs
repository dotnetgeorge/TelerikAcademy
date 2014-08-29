/*
 * Write a program that reads a list of words from a file words.txt and finds 
 * how many times each of the words is contained in another file test.txt.
 * The result should be written in the file result.txt and the words should be 
 * sorted by the number of their occurrences in descending order. 
 * Handle all possible exceptions in your methods.
 */
using System;
using System.IO;
using System.Collections.Generic;

class WordsCount
{
    static void Main(string[] args)
    {
        try
        {
            List<string> wordsList = new List<string>();
            StreamReader wordsReader = new StreamReader("words.txt");
            using (wordsReader)
            {
                string line = wordsReader.ReadLine();
                while (line != null)
                {
                    wordsList.Add(line);
                    line = wordsReader.ReadLine();
                }
            }

            List<string> testList = new List<string>();
            StreamReader testReader = new StreamReader("test.txt");
            using (testReader)
            {
                string line = testReader.ReadLine();
                while (line != null)
                {
                    testList.Add(line);
                    line = testReader.ReadLine();
                }
            }
            char[] remove = new char[] { ' ', ',', '.', '!', '?'};
            for (int i = 0; i < wordsList.Count; i++)
            {
                string[] elements = wordsList[i].Split(remove, StringSplitOptions.RemoveEmptyEntries);
                string word = null;
                for (int j = 0; j < elements.Length; j++)
                {
                    word += elements[j] + '\n';
                }
                wordsList[i] = word;
            }
            for (int i = 0; i < testList.Count; i++)
            {
                string[] elements = testList[i].Split(remove, StringSplitOptions.RemoveEmptyEntries);
                string word = null;
                for (int j = 0; j < elements.Length; j++)
                {
                    word += elements[j] + '\n';
                }
                testList[i] = word;
            }
            wordsList.Sort();
            testList.Sort();
            List<string> result = new List<string>();
            for (int i = 0; i < wordsList.Count; i++)
            {
                string add = null;
                int count = 0;
                for (int j = 0; j < testList.Count; j++)
                {
                    int index = testList[j].IndexOf(wordsList[i]);
                    while (index != -1)
                    {
                        count++;
                        index = testList[j].IndexOf(wordsList[i], index + 1);
                    }
                    add = "Word " + wordsList[i] + " founded " + count + " times in test.txt";
                }
                result.Add(add);
            }
            StreamWriter writer = new StreamWriter("result.txt");
            using (writer)
            {
                foreach (var item in result)
                {
                    writer.WriteLine(item);
                }
            }
        }
        catch (FileLoadException fle)
        {
            Console.Error.WriteLine(fle.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.Error.WriteLine(fnfe.Message);
        }
        catch (AccessViolationException ave)
        {
            Console.Error.WriteLine(ave.Message);
        }
    }
}