using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.MainUnits
{
    
    class PSPUnit
    {
        public List<Alarming.IVFDUnit> units;
        public string code;
        public PSPUnit(string code)
        {
            units = new List<Alarming.IVFDUnit>();
            this.code = code;
        }

        public void AddUnit(ref Alarming.IVFDUnit unit)
        {
            units.Add(unit);
        }

        public void Alarm(StrategyType strategy)
        {
            Call new_alarm_call;
            if (strategy == StrategyType.AllUnits)
            {
                new_alarm_call = new Call(StrategyType.AllUnits);
            }
            else
            {
                 new_alarm_call = new Call(StrategyType.OneUnit);
            }
            new_alarm_call.Start(ref units, code);

        }

        public void AddUnitObserver(Alarming.IVFDUnit unit)
        {
            units.Add(unit);
        }
    }
}
