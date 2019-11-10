using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.MainUnits
{
    public enum StrategyType
    {
        AllUnits, OneUnit
    }
    class Call
    {
        public ICallStrategy strategy;
        public Call(StrategyType strategy)
        {
            if(strategy == StrategyType.AllUnits)
                this.strategy = new AllUnitsStrategy();
            else
                this.strategy = new OneUnitStrategy();

        }

        public void Start(ref List<Alarming.IVFDUnit> units, string code)
        {
            strategy.StartCall(ref units, code);
        }
    }
}
