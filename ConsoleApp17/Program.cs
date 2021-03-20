using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("uzun kenari giriniz:");
            int UzunKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kisa kenari giriniz:");
            int KisaKenar= Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=KisaKenar; i++)
            {
                for (int j = 1; j <= UzunKenar; j++)
                {
                    if (i==1||i== KisaKenar||j == 1 || j == UzunKenar)
                    {
                        Console.Write("*");
                    }
        
                        else
                            Console.Write(" ");
                    }
                Console.WriteLine();
                }
                Console.ReadKey();
            }
            
            }
        }
    



