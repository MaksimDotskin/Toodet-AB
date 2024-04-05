﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Toodet_Dotskin
{
    internal class Kvitung
    {
        private List<string> toodet;
        private List<int> hinnad;
        private int summa;

        public Kvitung(List<string> Toodet, List<int> Hinnad, int Summa)
        {
            toodet = Toodet;
            hinnad = Hinnad;
            summa = Summa;

            string kaustatee = @"C:\Users\opilane\Source\Repos\Toodet-AB\Toodet_Dotskin\arved\";
            string failiNime = $"Check_{DateTime.Now:yyyyMMddHHmmss}.txt";
            string failiTee = Path.Combine(kaustatee, failiNime);

            try
            {
                if (!Directory.Exists(kaustatee))
                {
                    Directory.CreateDirectory(kaustatee);
                }

                using (StreamWriter kirjutaja = new StreamWriter(failiTee))
                {
                    kirjutaja.WriteLine("=====================================");
                    kirjutaja.WriteLine("|           Ostutšekk               |");
                    kirjutaja.WriteLine("=====================================");
                    kirjutaja.WriteLine("| Toode        |      Hind       |");
                    kirjutaja.WriteLine("|--------------|-----------------|");
                    for (int i = 0; i < toodet.Count; i++)
                    {
                        kirjutaja.WriteLine($"| {toodet[i],-12} | {hinnad[i],14:f2} |");
                        summa += hinnad[i];
                    }
                    kirjutaja.WriteLine("=====================================");
                    kirjutaja.WriteLine($"|{"Kokku:",-12} | {summa,14:f2} |");
                    kirjutaja.WriteLine("=====================================");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            
            Tsekk tsekk = new Tsekk("C:\\Users\\opilane\\Source\\Repos\\Toodet-AB\\Toodet_Dotskin\\arved\\"+failiNime,failiNime);
        }
    }
}
