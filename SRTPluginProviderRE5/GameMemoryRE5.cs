
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using SRTPluginProviderRE5.Structs;
using SRTPluginProviderRE5.Structs.GameStructs;
using System.Diagnostics;
using System.Reflection;

namespace SRTPluginProviderRE5
{
    public class GameMemoryRE5 : IGameMemoryRE5
    {
        private const string IGT_TIMESPAN_STRING_FORMAT = @"hh\:mm\:ss";
        public string GameName => "RE5";

        // Versioninfo
        public string VersionInfo => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        // GameInfo
        public string GameInfo { get => _gameInfo; set => _gameInfo = value; }
        internal string _gameInfo;

        // Chris HP
        public GamePlayer Player { get => _player; set => _player = value; }
        internal GamePlayer _player;

        // Sheva HP
        public GamePlayer Player2 { get => _player2; set => _player2 = value; }
        internal GamePlayer _player2;

        // Money
        public int Money { get => _money; set => _money = value; }
        internal int _money;

        // Kills Chris
        public int ChrisKills { get => _chrisKills; set => _chrisKills = value; }
        internal int _chrisKills;

        // Kills Sheva
        public int ShevaKills { get => _shevaKills; set => _shevaKills = value; }
        internal int _shevaKills;

        // Chris DA
        public short ChrisDA { get => _chrisDA; set => _chrisDA = value; }
        internal short _chrisDA;

        // Chris DA
        public short ChrisDARank { get => _chrisDARank; set => _chrisDARank = value; }
        internal short _chrisDARank;

        // Chris DA
        public short ShevaDA { get => _shevaDA; set => _shevaDA = value; }
        internal short _shevaDA;

        // Chris DA
        public short ShevaDARank { get => _shevaDARank; set => _shevaDARank = value; }
        internal short _shevaDARank;

        // Chapter
        public int Chapter { get => _chapter; set => _chapter = value; }
        internal int _chapter;

        // Enemy HP
        public EnemyHP[] EnemyHealth { get => _enemyHealth; set => _enemyHealth = value; }
        internal EnemyHP[] _enemyHealth;

        // Shots Fired
        public int ShotsFired { get => _shotsfired; set => _shotsfired = value; }
        internal int _shotsfired;

        // Enemies Hit
        public int EnemiesHit { get => _enemiesHit; set => _enemiesHit = value; }
        internal int _enemiesHit;

        // Deaths
        public int Deaths { get => _deaths; set => _deaths = value; }
        internal int _deaths;

        // IGT
        public float IGT { get => _igt; set => _igt = value; }
        internal float _igt;

        // SRank
        public bool IsSRank => Chapters.IsSRank(Chapter, EnemiesHit > 0 ? ShotsFired / EnemiesHit * 100 : 0, ChrisKills, Deaths, IGT);

        // Required Kills SRank
        public int KillsRequired => Chapters.GetKillsNeeded(Chapter);

        // Shots Fired 2
        public int ShotsFired2 { get => _shotsfired2; set => _shotsfired2 = value; }
        internal int _shotsfired2;

        // Enemies Hit 2
        public int EnemiesHit2 { get => _enemiesHit2; set => _enemiesHit2 = value; }
        internal int _enemiesHit2;

        // Deaths 2
        public int Deaths2 { get => _deaths2; set => _deaths2 = value; }
        internal int _deaths2;

        // IGT 2
        public float IGT2 { get => _igt2; set => _igt2 = value; }
        internal float _igt2;

        // SRank2
        public bool IsSRank2 => Chapters.IsSRank(Chapter, EnemiesHit2 > 0 ? ShotsFired2 / EnemiesHit2 * 100 : 0, ShevaKills, Deaths2, IGT2);

        public InventoryEntry[] PlayerInventory { get => _playerInventory; set => _playerInventory = value; }
        internal InventoryEntry[] _playerInventory;

        public InventoryEntry[] Player2Inventory { get => _player2Inventory; set => _player2Inventory = value; }
        internal InventoryEntry[] _player2Inventory;

        public TimeSpan IGTTimeSpan
        {
            get
            {
                TimeSpan timespanIGT;

                if (IGT >= 0f)
                    timespanIGT = TimeSpan.FromSeconds(IGT);
                else
                    timespanIGT = new TimeSpan();

                return timespanIGT;
            }
        }

        public string IGTFormattedString => IGTTimeSpan.ToString(IGT_TIMESPAN_STRING_FORMAT, CultureInfo.InvariantCulture);
    }
}
