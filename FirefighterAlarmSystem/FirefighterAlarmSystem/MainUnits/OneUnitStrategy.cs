using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirefighterAlarmSystem.Alarming;
using System.Collections;

namespace FirefighterAlarmSystem.MainUnits
{
    class OneUnitStrategy : ICallStrategy
    {
        public void StartCall(IVFDUnit[] units)
        {
            Random r = new Random();
            int c = r.Next(0, units.Length);
            //units[c].Notify()
        }
    }
}
