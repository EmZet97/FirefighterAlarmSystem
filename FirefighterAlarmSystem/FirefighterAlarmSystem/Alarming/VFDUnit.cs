using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.Alarming
{
    class VFDUnit : IVFDUnit
    {
        string unitName;
        string testCode;
        string alarmCode;

        public VFDUnit(string unitName, string testCode, string alarmCode)
        {
            this.unitName = unitName;
            this.testCode = testCode;
            this.alarmCode = alarmCode;
        }


        public string getUnitName()
        {
            return unitName;
        }

        public void setUnitName(string unitName)
        {
            this.unitName = unitName;
        }

        public string getTestCode()
        {
            return testCode;
        }

        public void setTestCode(string testCode)
        {
            this.testCode = testCode;
        }

        public string getAlarmCode()
        {
            return alarmCode;
        }

        public void setAlarmCode(string alarmCode)
        {
            this.alarmCode = alarmCode;
        }



        public ResponseCode notify(string CCIR_CODE)
        {
            /**
             * 
             * TO DO
             * 
             */
            return ResponseCode.ERROR;
        }

    }
}
