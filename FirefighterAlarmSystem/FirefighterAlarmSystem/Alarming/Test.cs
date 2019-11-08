using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.Alarming
{
    class Test : IAlarmState
    {
        public void StartState()
        {
            Console.WriteLine("Uruchomienie trybu testowego");

            Console.WriteLine("Alarm testowy");
        }
    }
}
