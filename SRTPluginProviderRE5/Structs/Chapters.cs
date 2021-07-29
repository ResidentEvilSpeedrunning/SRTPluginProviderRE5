using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRTPluginProviderRE5.Structs
{
    public class Chapters
    {
        public int Accuracy;
        public int Kills;
        public int Deaths;
        public float Time;

        public Chapters(int accuracy, int kills, int deaths, float time)
        {
            Accuracy = accuracy;
            Kills = kills;
            Deaths = deaths;
            Time = time;
        }

        public static Dictionary<int, Chapters> SRank = new Dictionary<int, Chapters>()
        {
            { 0, new Chapters(70, 20, 0, 720f) },
            { 1, new Chapters(70, 15, 0, 780f) },
            { 2, new Chapters(70, 60, 0, 1380f) },
            { 3, new Chapters(70, 50, 0, 1320f) },
            { 4, new Chapters(70, 40, 0, 540f) },
            { 5, new Chapters(70, 30, 0, 1080f) },
            { 6, new Chapters(70, 50, 0, 1140f) },
            { 7, new Chapters(70, 30, 0, 1140f) },
            { 8, new Chapters(70, 50, 0, 1380f) },
            { 9, new Chapters(70, 35, 0, 960f) },
            { 10, new Chapters(70, 7, 0, 720f) },
            { 11, new Chapters(70, 40, 0, 1320f) },
            { 12, new Chapters(70, 30, 0, 2280f) },
            { 13, new Chapters(70, 40, 0, 1560f) },
            { 14, new Chapters(70, 35, 0, 1380f) },
            { 15, new Chapters(70, 25, 0, 1320f) },
        };

        public static int GetKillsNeeded(int currentChapter)
        {
            return SRank[currentChapter].Kills;
        }

        public static bool IsSRank(int currentChapter, int accuracy, int kills, int deaths, float time)
        {
            if (accuracy >= SRank[currentChapter].Accuracy && kills >= SRank[currentChapter].Kills && deaths >= SRank[currentChapter].Deaths && time >= SRank[currentChapter].Time)
            {
                return true;
            }
            return false;
        }
    }
}
