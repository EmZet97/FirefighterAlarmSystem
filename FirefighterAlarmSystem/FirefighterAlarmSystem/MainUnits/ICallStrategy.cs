using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.MainUnits
{
    interface ICallStrategy
    {
        void StartCall(ref List<Alarming.IVFDUnit> units, string code);
    }
}
