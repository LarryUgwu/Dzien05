using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            //try 
            //{
            //    //problematyczny kod
            //    int i = 10, j = 0, k = 0;
            //        k = i / j;
            //}
            //catch (Exception exc)
            //{
            //    //obsługa wyjątku
            //    Console.WriteLine("Wystąpił wyjątek: {0}", exc.Message);

            //}
            //Console.ReadKey();

            //try
            //{
            //    //problematyczny kod
            //    int i = 10, j = 0, k = 0;
            //    //k = i / j;
            //    string s1 = Console.ReadLine();
            //    int x = Int32.Parse(s1);

            //    string s2 = Console.ReadLine();
            //    SByte y = SByte.Parse(s2);

            //    //samodzielne generowanie wyjątku

            //    if(y==1)
            //    {
            //        throw new Exception("Wartość 1 nie jest dozwolona!");
            //    }

            //    Console.WriteLine(x / y);



            //}
            //catch (OverflowException exc)
            //{
            //    Console.WriteLine("Przepełnienie: {0}", exc.Message);
            //}

            //catch (ArithmeticException exc)
            //{
            //    //obsługa wyjątku
            //    Console.WriteLine("Wystąpił wyjątek arytmetyczny: {0}", exc.Message);
            //}
            ////zły format
            //catch (FormatException exc)
            //{
            //    Console.WriteLine("Zły format: {0}", exc.Message);
            //}
            ////przepelnienie
            //catch (Exception exc)
            //{
            //    Console.WriteLine("General Error: {0}", exc.Message);
            //}

            //finally //wywoła sie niezależnie od tego czy bedzie wyjątek czy nie
            //// używane np do usunięcia plików tymczasowych, zwolnienia pamięci itp
            //{
            //    Console.WriteLine("to się zawsze wykona");
            //}
            //// sekcja się nie wykona, jesli wyjątkiem będzie "out of memory"



            //Console.ReadKey();


            //try w try

            try
            {



                try
                {
                    //problematyczny kod
                    int i = 10, j = 0, k = 0;
                    //k = i / j;
                    string s1 = Console.ReadLine();
                    int x = Int32.Parse(s1);

                    string s2 = Console.ReadLine();
                    SByte y = SByte.Parse(s2);

                    //samodzielne generowanie wyjątku

                    if (y == 1)
                    {
                        throw new Exception("Wartość 1 nie jest dozwolona!");
                    }

                    Console.WriteLine(x / y);

                }


                catch (OverflowException exc)
                {
                    Console.WriteLine("Przepełnienie: {0}", exc.Message);
                }

                catch (ArithmeticException exc)
                {
                    //obsługa wyjątku
                    Console.WriteLine("Wystąpił wyjątek arytmetyczny: {0}", exc.Message);
                }
                //zły format
                catch (FormatException exc)
                {
                    Console.WriteLine("Zły format: {0}", exc.Message);
                    throw;  //transmisja wyjątku - jak są dwa "try" to jesli wyjątek 
                            //wystapi w srodkowym TRY, bez throw nie bedzie informacji 
                            //w zewnętrznym TRY
                }
                //przepelnienie
                catch (Exception exc)
                {
                    Console.WriteLine("General Error: {0}", exc.Message);
                }

                finally //wywoła sie niezależnie od tego czy bedzie wyjątek czy nie
                        // używane np do usunięcia plików tymczasowych, zwolnienia pamięci itp
                {
                    Console.WriteLine("to się zawsze wykona");
                }
                // sekcja się nie wykona, jesli wyjątkiem będzie "out of memory"

            } catch (Exception exc)
            {
                Console.WriteLine("Wyjątek zewnętrzny: {0}", exc.Message);
            }

            Console.ReadKey();
        }
    }
}
