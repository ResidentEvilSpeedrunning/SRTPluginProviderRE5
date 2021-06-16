using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SRTPluginProviderRE5.Structs.GameStructs
{

    [DebuggerDisplay("{_DebuggerDisplay,nq}")]
    public struct InventoryEntry
    {
        /// <summary>
        /// Debugger display message.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string _DebuggerDisplay
        {
            get
            {
                return string.Format("[#{0}] - {1} - {2}", SlotNo, ItemID.ToString(), StackSize);
            }
        }

        public Item ItemID { get => _itemID; set => _itemID = value; }
        internal Item _itemID;

        public string ItemName => ItemID.ToString();
        public int StackSize { get => _stackSize; set => _stackSize = value; }
        internal int _stackSize;
        public int SlotNo { get => _slotNo; set => _slotNo = value; }
        internal int _slotNo;
        public ItemState EquippedState { get => _equippedState; set => _equippedState = value; }
        internal ItemState _equippedState;
        public bool IsItem => Enum.IsDefined(typeof(Item), _itemID);
    }

    public enum Item : int
    {
        None,
        HandToHand = 256,
        Knife = 257,
        M92F = 258,
        VZ61 = 259,
        IthacaM37 = 260,
        S75 = 261,
        HG = 262, // Handgrenade
        IG = 263, // Incendiary
        FG = 264, // Flash
        SIG556 = 265,
        ProimityMines = 266,
        SWM29 = 267,
        GL = 268, // Grenade Launcher
        RL = 269, // RL = Rocket Launcher
        Knife2 = 270,
        Longbow = 271,
        HKP8 = 272,
        P226 = 273,
        SamuraiEdge = 274,
        MP5 = 275,
        GatlingGun = 277,
        M3 = 278,
        JailBreaker = 279,
        Hydra = 281,
        LHawk = 282,
        M5000 = 283,
        PSG1 = 284,
        AK74 = 285,
        M93R = 286,
        PX4 = 287,
        DragunovSVD = 288,
        Flamethrower = 289,
        StunRod = 290,
        Knife3 = 291,
        Knife4 = 292, // Working knives (Dont know why there are so many)
        GLEXP = 293, // GL = Grenade Launcher (Next to it are the rounds in there when equipped, therefore belongs to WeaponEnum)
        GLACD = 294,
        GLICE = 295,
        SamuraiEdge2 = 297, // Can you even use the Samurai Edge at all?
        GLFLM = 313,
        GLFLS = 314,
        GLELC = 315,
        EggWhite = 316,
        EggBrown = 317,
        EggGold = 318,
        HGAmmo = 513,
        MGAmmo = 514,
        SGAmmo = 515,
        RifleAmmo = 516,
        ExplosiveRounds = 518,
        AcidRounds = 519,
        NitrogenRounds = 520,
        MagnumAmmo = 521,
        FlameRounds = 526,
        FlashRounds = 527,
        ElectricRounds = 528,
        RPGRound = 529,
        FAS = 772,
        HerbG = 773,
        HerbR = 774,
        HerbGG = 775,
        HerbGR = 777,
        MeleeVest = 1537,
        BulletproofVest = 1542,
    }

    public enum ItemState : int
    {
        None,
        Current,
        Previous
    }
}
