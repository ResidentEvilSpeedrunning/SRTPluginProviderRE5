using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SRTPluginProviderRE5.Structs.GameStructs
{

    [DebuggerDisplay("{_DebuggerDisplay,nq}")]
    public struct EnemyHP
    {
        /// <summary>
        /// Debugger display message.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string _DebuggerDisplay
        {
            get
            {
                if (IsTrigger)
                    return string.Format("TRIGGER", CurrentHP, MaximumHP, Percentage);
                else if (IsAlive)
                    return string.Format("{0} / {1} ({2:P1})", CurrentHP, MaximumHP, Percentage);
                else
                    return "DEAD / DEAD (0%)";
            }
        }

        public short MaximumHP { get => _maximumHP; }
        internal short _maximumHP;

        public short CurrentHP { get => _currentHP; }
        internal short _currentHP;

        public bool IsTrigger => MaximumHP == 1 && CurrentHP == 1 || MaximumHP == 100 || MaximumHP == 16693 || MaximumHP == 200; // Some triggers load in as enemies as 1/1 hp. We're excluding that by checking to make sure max hp is greater than 1 rather than greater than 0.
        public bool IsAlive => !IsTrigger && MaximumHP > 0 && CurrentHP > 0 && CurrentHP <= MaximumHP && MaximumHP != 28000 || !IsTrigger && CurrentHP < 28000 && MaximumHP == 28000;
        public float Percentage => ((IsAlive) ? (float)CurrentHP / (float)MaximumHP : 0f);
    }
}
