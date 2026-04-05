using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022400076 
{
    class SayaPlayTrack
    {
        private string title;       
        private int playCount;     

        public SayaPlayTrack(string title, int playCount)
        {
            if (title == null)
                throw new ArgumentException("Title tidak boleh null!");

            if (playCount > 100_000_000)
                throw new ArgumentException("Play count melebihi batas maksimal (100 juta)!");

            this.title = title;
            this.playCount = playCount;
        }
        public void increasePlayCount(int count)
        {

            if (this.playCount + count > 100_000_000)
                throw new OverflowException("Total play count tidak boleh melebihi 100 juta!");

            this.playCount += count; 
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("=== TRACK DETAILS ===");
            Console.WriteLine("Title     : " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
            Console.WriteLine("=====================");
        }
    }
}