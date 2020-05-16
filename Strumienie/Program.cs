using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strumienie
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(@"c:\tmp\test.txt");
                //streamwriter tworzy plik o podanej nazwie, jesli taki plik tam jest, 
                //jest nadpisywany

                //sw.AutoFlush = true; //nie trzeba wtedy robić Flush

                for (int i = 1; i <= 10; i++)
                {
                    sw.WriteLine(String.Format("Linia nr {0}", i));
                }

                sw.Flush(); //opróżnienie bufora (przy zapisie dużej ilości danych)
                sw.Close(); //pamiętać o zamykaniu pliku
            } catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                //zamykanie strumienia
                if (sw != null)
                {
                    sw.Close();
                }
            }
            // using - resource/context manager (automatyczne zwalnianie zasobow)
            try
            {
                using (StreamWriter sw1 = new StreamWriter(@"c:\tmp\test1.txt"))
                {
                    sw1.Write("ABCD");
                }

                    

            } catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }


            //odczyt danych za pomocą klasy FileStream
            String s = null;
            String path = @"c:\tmp\test.txt";
            byte[] data;

            //czy plik istnieje
            if(File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);

                data = new byte[fs.Length]; //deklaracja tablicy do której mają być zczytane dane z pliku
                fs.Read(data, 0, (int)fs.Length); //czytaj plik od poczatku do końca
                fs.Close();
                //odcztane dane są w formie ascii, więc trzeba je skonwertować:

                s = Encoding.UTF8.GetString(data);
                Console.WriteLine(s);
                //Console.ReadKey();
            }

            //sekwencyjny odczyt danych - linia po linii

            StreamReader sr = new StreamReader(path);
            string result = "";

            StringBuilder sb = new StringBuilder(100); //efektywan konkatenacja zamiast dodawania stringów za pomocą "+"

            do
            {
                s = sr.ReadLine();
                //result += s + Environment.NewLine;
                sb.AppendLine(s);

            } while (s != null); //czyli czytaj plik, dopoki się nie skończy

            Console.WriteLine(sb.ToString()); // zamiast cw(result);
            Console.ReadKey();

        }


       
    }
}
