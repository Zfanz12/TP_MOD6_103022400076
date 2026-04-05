using System;

namespace TP_MODUL6_103022400076
{
    class Program
    {
        static void Main(string[] args)
        {

            SayaPlayTrack track = new SayaPlayTrack("Bohemian Rhapsody", 500);

            Console.WriteLine("Sebelum ditambah:");
            track.PrintTrackDetails();

            track.increasePlayCount(200);

            Console.WriteLine("Sesudah ditambah 200:");
            track.PrintTrackDetails();


            try
            {
                SayaPlayTrack trackBesar = new SayaPlayTrack("Lagu Viral", 99_000_000);
                trackBesar.increasePlayCount(5_000_000); 
            }
            catch (OverflowException e)
            {

                Console.WriteLine("\n[EXCEPTION TERTANGKAP]: " + e.Message);
            }

            Console.ReadKey(); 
        }
    }
}