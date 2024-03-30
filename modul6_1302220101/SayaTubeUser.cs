using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220101
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public String Username;

        public SayaTubeUser(string Username)
        {
            Debug.Assert(Username.Length <= 100, "Nama username memiliki panjang maksimal 100 karkter");
            Debug.Assert(Username != null, "Nama username tidak berupa null");
            this.Username = Username;
            uploadedVideos = new List<SayaTubeVideo>();
            Random rd = new Random();
            id = rd.Next(10000, 99999);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;

            foreach (SayaTubeVideo video in uploadedVideos)
            {
                total += video.getPlayCount();
            }

            return total;
        }

        public void addVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null, "Video yang ditambahkan tidak berupa null");
            Debug.Assert(video.getPlayCount() < int.MaxValue, "Video yang ditambahkan punya playcount < int maks");
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            
            for (int i = 0; (i < uploadedVideos.Count || i < 8); i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].getTitle()}");
                //Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
