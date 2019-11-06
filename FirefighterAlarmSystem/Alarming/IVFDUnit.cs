using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.Alarming
{
    interface IVFDUnit
    {
        ResponseCode notify(String CCIR_CODE);
    }
}
