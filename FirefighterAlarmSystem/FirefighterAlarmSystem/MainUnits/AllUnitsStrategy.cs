using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirefighterAlarmSystem.Alarming;

namespace FirefighterAlarmSystem.MainUnits
{
    class AllUnitsStrategy : ICallStrategy
    {
        public void StartCall(ref List<IVFDUnit> units, string code)
        {
            foreach (VFDUnit unit in units)
            {
                string ccir_code = code + "-" + ((Alarming.VFDUnit)unit).GetUnitName();
                unit.Notify(ccir_code);
            }
        }
    }
}
