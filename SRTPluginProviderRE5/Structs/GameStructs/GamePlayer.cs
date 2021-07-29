using System.Runtime.InteropServices;

namespace SRTPluginProviderRE5.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x4)]

    public unsafe struct GamePlayer
    {
        [FieldOffset(0x0)] private short currentHP;
        [FieldOffset(0x2)] private short maxHP;

        public short CurrentHP => currentHP;
        public short MaxHP => maxHP;
        public float Percentage => CurrentHP > 0 ? (float)CurrentHP / (float)MaxHP : 0f;
        public bool IsAlive => CurrentHP != 0 && CurrentHP > 0 && CurrentHP <= MaxHP;
        public PlayerStatus HealthState
        {
            get =>
                !IsAlive ? PlayerStatus.Dead :
                Percentage >= 0.66f ? PlayerStatus.Fine :
                Percentage >= 0.33f ? PlayerStatus.Caution : 
                PlayerStatus.Danger;
        }

        public string CurrentHealthState => HealthState.ToString();
    }

    public enum PlayerStatus
    {
        Dead,
        Fine,
        Caution,
        Danger
    }
}