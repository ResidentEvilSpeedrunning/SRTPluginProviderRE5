using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SRTPluginProviderRE5.Structs.GameStructs
{

    [DebuggerDisplay("{_DebuggerDisplay,nq}")]
    public struct StoreInventoryEntry
    {
        /// <summary>
        /// Debugger display message.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string _DebuggerDisplay
        {
            get
            {
                return string.Format("{0} - {1}", ItemID.ToString(), Quantity);
            }
        }

        public Item ItemID { get => _itemID; set => _itemID = value; }
        internal Item _itemID;
        public short Quantity { get => _quantity; set => _quantity = value; }
        internal short _quantity;
        public byte Damage { get => _damage; set => _damage = value; }
        internal byte _damage;
        public byte ReloadSpeed { get => _reloadSpeed; set => _reloadSpeed = value; }
        internal byte _reloadSpeed;
        public byte StackSize { get => _stackSize; set => _stackSize = value; }
        internal byte _stackSize;
        public byte CriticalRate { get => _criticalRate; set => _criticalRate = value; }
        internal byte _criticalRate;
        public byte Piercing { get => _piercing; set => _piercing = value; }
        internal byte _piercing;
        public byte ScopeRate { get => _scopeRate; set => _scopeRate = value; }
        internal byte _scopeRate;
        public byte MaxDamage { get => _maxDamage; set => _maxDamage = value; }
        internal byte _maxDamage;
        public byte MaxReloadSpeed { get => _maxReloadSpeed; set => _maxReloadSpeed = value; }
        internal byte _maxReloadSpeed;
        public byte MaxStackSize { get => _maxStackSize; set => _maxStackSize = value; }
        internal byte _maxStackSize;
        public bool IsItem => Enum.IsDefined(typeof(Item), _itemID);
    }
}
