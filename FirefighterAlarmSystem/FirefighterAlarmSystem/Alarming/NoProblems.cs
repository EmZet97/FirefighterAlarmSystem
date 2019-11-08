using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.Alarming
{
    class NoProblems : IAlarmState
    {
        public void StartState()
        {
            Console.WriteLine("Uruchomienie trybu oczekiwania");

            Console.WriteLine("Alarm wyłączony");
        }
    }
}
