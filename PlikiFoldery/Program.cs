using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace PlikiFoldery      
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    string path = @"c:\tmp\plik.txt";

        //    if(File.Exists(path))
        //    {
        //        File.Delete(path);
        //    }

        //    StreamWriter sw = File.CreateText(path);
        //    sw.Close();

        //    File.WriteAllText(path, "La La La");

        //    File.Copy(path, @"c:\tmp\plik2.txt", true);
        //    File.Move(@"c:\tmp\plik2.txt", @"c:\tmp\plik100.txt");

        //    String s = File.ReadAllText(path);
        //    Console.WriteLine(s);
        //    Console.ReadKey();
        //}

        
        
        
        //operacje na folderach
        {

            CopyDir(@"c:\tmp", @"c:\tmp2");

            String folderName = @"c:\test\alx";
            if(!Directory.Exists(folderName))
            {
                //utworz folder
                Directory.CreateDirectory(folderName);
            }

            Directory.Move(folderName, @"c:\test\csharp");

            Directory.Delete(@"c:\test\csharp", true);


            //string path = @"c:\tmp\plik.txt";

            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}

            //StreamWriter sw = File.CreateText(path);
            //sw.Close();

            //File.WriteAllText(path, "La La La");

            //File.Copy(path, @"c:\tmp\plik2.txt", true);
            //File.Move(@"c:\tmp\plik2.txt", @"c:\tmp\plik100.txt");

            //String s = File.ReadAllText(path);
            //Console.WriteLine(s);
            //Console.ReadKey();
        }

        static void CopyDir(string sourceDir, string targetDir)
        {
            if(!sourceDir.EndsWith(@"\"))
            {
                sourceDir += @"\";
            }

            if (!targetDir.EndsWith(@"\"))
            {
                targetDir += @"\";
            }

            //pobierz wszystkie pliki i nazwy podfolderów z sourceDir

            string[] files = Directory.GetFileSystemEntries(sourceDir);

            //tworzenie folderu docelowego targetDir

            Directory.CreateDirectory(targetDir);

            //iterowanie po tablicy files[]

            for (int i = 0; i < files.Length; i++)
            {
                string srcFile = files[i];
                Console.WriteLine(srcFile);
                FileAttributes attr = File.GetAttributes(srcFile);
                if (attr == FileAttributes.Directory)
                {
                    //obsługa rekurencyjna kopiowania folderów
                    String newFolder = targetDir + Path.GetFileName(srcFile);
                    if(!Directory.Exists(newFolder))
                    {
                        Directory.CreateDirectory(newFolder);
                    }
                    CopyDir(srcFile, newFolder);
                }
                else
                {
                    //kopiowanie
                    File.Copy(srcFile, targetDir + Path.GetFileName(srcFile));
                }
            }
        
        }

    }
}
