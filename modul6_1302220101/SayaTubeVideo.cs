using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220101
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String judul)
        {
            Debug.Assert(judul.Length < 200, "Judul video memiliki maksimal 200 karakter");
            Debug.Assert(judul != null, "Judul video tidak berupa null");
            this.title = judul;
            playCount = 0;
            Random rd = new Random();
            id = rd.Next(10000, 99999);
        }

        public String getTitle()
        {
            return title;
        }

        public int getPlayCount() { return playCount;}

        public void increasePlayCount(int inputPlayCount)
        {
            Debug.Assert(inputPlayCount <= 25000000, "Input playCount maksimal 25.000.000 per panggilan method");
            Debug.Assert(inputPlayCount >= 0, "input PlayCount tidak berupa negatif");
            try
            {
                checked
                {
                    playCount += inputPlayCount;
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void printVideoDetails()
        {
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"title: {title}");
            Console.WriteLine($"playCount: {playCount}");
        }
    }
}
