using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarming.IVFDUnit unit1 = new Alarming.VFDUnit("Jednostka1", "test", "alarm");
            Firefighters.Firefighter f1 = new Firefighters.Firefighter("Daniel", "Z", "123123");
            Firefighters.Firefighter f2 = new Firefighters.Firefighter("Adrian", "W", "123123");
            Firefighters.Firefighter f3 = new Firefighters.Firefighter("Milena", "S", "123123");
            Firefighters.Firefighter f4 = new Firefighters.Firefighter("Bartek", "W", "123123");
            ((Alarming.VFDUnit)unit1).AddFirefighterObserver(ref f1);
            ((Alarming.VFDUnit)unit1).AddFirefighterObserver(ref f2);
            ((Alarming.VFDUnit)unit1).AddFirefighterObserver(ref f3);
            ((Alarming.VFDUnit)unit1).AddFirefighterObserver(ref f4);


            Alarming.IVFDUnit unit2 = new Alarming.VFDUnit("Jednostka2", "test", "alarm");
            Firefighters.Firefighter f5 = new Firefighters.Firefighter("Daniel", "W", "123123");
            Firefighters.Firefighter f6 = new Firefighters.Firefighter("Marcin", "W", "123123");
            Firefighters.Firefighter f7 = new Firefighters.Firefighter("Bartek", "Z", "123123");
            ((Alarming.VFDUnit)unit2).AddFirefighterObserver(ref f5);
            ((Alarming.VFDUnit)unit2).AddFirefighterObserver(ref f6);
            ((Alarming.VFDUnit)unit2).AddFirefighterObserver(ref f7);


            string code = "alarm";
            //code = "test";


            MainUnits.PSPUnit pspunit = new MainUnits.PSPUnit(code);
            pspunit.AddUnitObserver(unit1);
            pspunit.AddUnitObserver(unit2);

            pspunit.Alarm(MainUnits.StrategyType.OneUnit);

            Console.ReadKey();
        }
    }
}
