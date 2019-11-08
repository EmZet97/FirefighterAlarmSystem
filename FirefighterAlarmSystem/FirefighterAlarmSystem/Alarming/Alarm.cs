using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.Alarming
{
    class Alarm : IAlarmState
    {
        public void StartState()
        {
            Console.WriteLine("Uruchomienie trybu alarmu");

            Console.WriteLine("Alarm, alarm, alaaaaaaaaaaaaarm!");
        }
    }
}
