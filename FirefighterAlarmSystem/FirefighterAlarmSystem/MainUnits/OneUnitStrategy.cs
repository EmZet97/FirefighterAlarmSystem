﻿using System;
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
        public void StartCall(ref List<IVFDUnit> units, string code)
        {
            Random r = new Random();
            int c = r.Next(0, units.Count);
            string ccir_code = code + "-" + ((Alarming.VFDUnit)units[c]).GetUnitName();
            foreach (VFDUnit unit in units)
            {
                unit.Notify(ccir_code);
            }
            //units[c].Notify("");
        }
    }
}
