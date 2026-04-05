using System;
using TP_MODUL6_103022400076;

namespace TP_MODUL6_1030222400076
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== TEST NORMAL ===");
            SayaPlayTrack track = new SayaPlayTrack("Bohemian Rhapsody", 500);
            track.PrintTrackDetails();

            track.increasePlayCount(200);
            Console.WriteLine("Setelah ditambah 200:");
            track.PrintTrackDetails();

            Console.WriteLine("\n=== TEST OVERFLOW EXCEPTION ===");

            try
            {
                SayaPlayTrack trackOverflow = new SayaPlayTrack("Lagu Overflow", 0);

                // Setiap iterasi menambah 10 juta
                // Loop akan terus jalan sampai overflow terjadi
                for (int i = 0; i < 1000; i++)
                {
                    trackOverflow.increasePlayCount(10_000_000);
                    Console.WriteLine("Iterasi ke-" + (i + 1) + " | Play Count: " + trackOverflow);
                }
            }
            catch (OverflowException e)
            {

                Console.WriteLine("[OVERFLOW TERTANGKAP] " + e.Message);
            }

            Console.WriteLine("\nProgram selesai tanpa crash!");
            Console.ReadKey();
        }
    }
}