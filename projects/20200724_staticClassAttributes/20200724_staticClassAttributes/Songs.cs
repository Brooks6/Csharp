using System;
namespace _20200724_staticClassAttributes
{
    public class Songs
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Songs(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songCount++;
        }

        public int getSongCount() {
            return songCount;
        }
    }
}
