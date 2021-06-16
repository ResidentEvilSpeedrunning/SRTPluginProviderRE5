using System.Runtime.InteropServices;

namespace SRTPluginProviderRE5.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]

    public unsafe struct GameStoreInventory
    {
        [FieldOffset(0x0)] public short ItemID;
        [FieldOffset(0x2)] public short Quantity;
        [FieldOffset(0x30)] public short Damage;
        [FieldOffset(0x31)] public short ReloadSpeed;
        [FieldOffset(0x32)] public short StackSize;
        [FieldOffset(0x33)] public short CriticalRate;
        [FieldOffset(0x34)] public short Piercing;
        [FieldOffset(0x36)] public short ScopeRate;
        [FieldOffset(0x40)] public short MaxDamage;
        [FieldOffset(0x41)] public short MaxReloadSpeed;
        [FieldOffset(0x42)] public short MaxStackSize;
        [FieldOffset(0x44)] public fixed byte filler[4];

        public static GameStoreInventory AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(GameStoreInventory*)pb;
            }
        }
    }
}