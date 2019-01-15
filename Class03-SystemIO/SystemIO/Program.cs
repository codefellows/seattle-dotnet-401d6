using System;
using System.IO;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vinicio - we are relying on the intenal structure of the project
            string path = "../../../testFile.txt";
            CreateFile(path);
            //ReadFile(path);
            //AppendToFile(path);
            //DeleteFile(path);
            //PlayingWithSplit();
        }

        static void CreateFile(string path)
        {
            // Using statement (finally ALL IN ONE)
            try
            {
                // Vinicio - the using is only making sure that you closer your file
                using(StreamWriter streamWriter = new StreamWriter(path))
                {
                    // Vinicio - as soon as I leave this block. THe engine will dispose
                    // streamWriter

                    //Console.WriteLine("Gregor is the very best");
                    try
                    {
                        streamWriter.WriteLine("INheritance is about what things are -- NEW FILE");
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                } 

            }
            catch (IOException e)
            {

                Console.Write(e);
                throw;
            }
            catch (NotSupportedException e)
            {

                Console.Write(e);
                throw;
            }
            catch (Exception e)
            {

                Console.Write(e);
                throw;
            }
            //try
            //{
            //    // CREATE FILE 

            //}
            //catch (Exception e)
            //{
            //    // HANDLE ERRORS
            //}
            //finally
            //{
            //    // DISPOSE FILE
            //}

        }

        static void ReadFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                for(int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void AppendToFile(string path)
        {
            try
            {
                using(StreamWriter streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine("This is a new line that's going to be added to the file");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);

            }
            catch (Exception)
            {

                throw;
            }
        }

        static void PlayingWithSplit()
        {
            char[] delimiterCharacters = {' ', ',', '.', ':', '\t'};
            string textToSplit = "one\ttwo three,four:five";
            string[] words = textToSplit.Split(delimiterCharacters);
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
