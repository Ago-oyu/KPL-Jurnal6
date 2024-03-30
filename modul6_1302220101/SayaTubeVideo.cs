using System;
using System.Collections.Generic;
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
            playCount += inputPlayCount;
        }

        public void printVideoDetails()
        {
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"title: {title}");
            Console.WriteLine($"playCount: {playCount}");
        }
    }
}
