using System;
using System.Diagnostics; 

namespace TP_MODUL6_103022400076
{
    class SayaPlayTrack
    {
        private string title;
        private int playCount;

        public SayaPlayTrack(string title, int playCount)
        {

            Debug.Assert(title != null, "Precondition gagal: Title tidak boleh null!");


            Debug.Assert(title.Length <= 100, "Precondition gagal: Title maksimal 100 karakter!");

            this.title = title;
            this.playCount = playCount;
        }

        public void increasePlayCount(int count)
        {

            Debug.Assert(count <= 10_000_000, "Precondition gagal: Penambahan maksimal 10.000.000 per pemanggilan!");

            checked
            {
                playCount += count;
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("=== TRACK DETAILS ===");
            Console.WriteLine("Title     : " + title);
            Console.WriteLine("Play Count: " + playCount);
            Console.WriteLine("=====================");
        }
    }
}