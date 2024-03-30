namespace modul6_1302220101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser User = new SayaTubeUser("Yoga");

            SayaTubeVideo vid1 = new SayaTubeVideo("Casino Royale oleh Yoga");
            SayaTubeVideo vid2 = new SayaTubeVideo("Avatar oleh Yoga");
            SayaTubeVideo vid3 = new SayaTubeVideo("Parasite oleh Yoga");
            SayaTubeVideo vid4 = new SayaTubeVideo("Come and See oleh Yoga");
            SayaTubeVideo vid5 = new SayaTubeVideo("Harakiri oleh Yoga");
            SayaTubeVideo vid6 = new SayaTubeVideo("The Godfather oleh Yoga");
            SayaTubeVideo vid7 = new SayaTubeVideo("Seven Samurai oleh Yoga");
            SayaTubeVideo vid8 = new SayaTubeVideo("Spirited Away oleh Yoga");
            SayaTubeVideo vid9 = new SayaTubeVideo("Spider-Man oleh Yoga");
            SayaTubeVideo vid10 = new SayaTubeVideo("The Dark Knight oleh Yoga");

            User.addVideo(vid1);
            User.addVideo(vid2);
            User.addVideo(vid3);
            User.addVideo(vid4);
            User.addVideo(vid5);
            User.addVideo(vid6);
            User.addVideo(vid7);
            User.addVideo(vid8);
            User.addVideo(vid9);
            User.addVideo(vid10);

            vid1.increasePlayCount(39);
            vid1.printVideoDetails();
            Console.WriteLine();
            User.PrintAllVideoPlaycount();
        }
    }
}
