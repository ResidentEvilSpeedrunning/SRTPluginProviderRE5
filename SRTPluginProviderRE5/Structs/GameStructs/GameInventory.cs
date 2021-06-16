using System.Runtime.InteropServices;

namespace SRTPluginProviderRE5.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe struct GameInventory
    {
        [FieldOffset(0x4)] public int ItemID;
        [FieldOffset(0x8)] public int Quantity;
        [FieldOffset(0x18)] public int SlotNo;
        [FieldOffset(0x1C)] public int State;
        [FieldOffset(0x20)] public fixed byte filler[16];

        public static GameInventory AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(GameInventory*)pb;
            }
        }
    }
}