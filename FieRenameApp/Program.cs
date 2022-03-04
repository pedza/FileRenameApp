using System;
using System.IO;

namespace FieRenameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a path");
            string folderPath = Console.ReadLine();
            Console.WriteLine("New folder destination");
            string destinationRenameFolder = Console.ReadLine();
           

            string[] files = Directory.GetFiles(folderPath);
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                File.Copy(file, $@"{destinationRenameFolder}\BELLDINI_{partOfFileName(0, FileName(file))}_{partOfFileName(2, FileName(file))}_{partOfFileName(3, FileName(file))}");
                
            }

            string FileName(string path)
            {
                string fileNameClean = Path.GetFileName(path);

                return fileNameClean;
            }

            string partOfFileName(int index, string nameOfFile)
            {
                string[] partOfName = nameOfFile.Split(" ");

                for (int i = 0; i < partOfName.Length; i++)
                {
                    return partOfName[index];
                }
                return "";
            }

        }
    }
}
