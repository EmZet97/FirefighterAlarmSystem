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
        private List<Firefighters.IFirefighter> firefighters;

        //Unit states
        AlarmState state;
        AlarmState alarm;
        AlarmState waiting;
        AlarmState test;

        public VFDUnit(string unitName, string testCode, string alarmCode)
        {
            this.unitName = unitName;
            this.testCode = testCode;
            this.alarmCode = alarmCode;
            firefighters = new List<Firefighters.IFirefighter>();
            //Init states
            alarm = new Alarm();
            waiting = new NoProblems();
            test = new Test();
            //Seting default state
            state = waiting;
        }

        public void AddFirefighterObserver(Firefighters.Firefighter firefighter)
        {
            //Add new firefighter observer
            firefighters.Add(firefighter);
        }


        public string GetUnitName()
        {
            return unitName;
        }

        public void SetUnitName(string unitName)
        {
            this.unitName = unitName;
        }

        public string GetTestCode()
        {
            return testCode;
        }

        public void SetTestCode(string testCode)
        {
            this.testCode = testCode;
        }

        public string GetAlarmCode()
        {
            return alarmCode;
        }

        public void SetAlarmCode(string alarmCode)
        {
            this.alarmCode = alarmCode;
        }



        public ResponseCode Notify(string CCIR_CODE)
        {
            
            if(CCIR_CODE.Contains(this.alarmCode) && CCIR_CODE.Contains(this.unitName))
            {
                ChangeState(ref alarm);
                StartAlarm();
                return ResponseCode.ALARM_OK;
            }
            if (CCIR_CODE.Contains(this.testCode) && CCIR_CODE.Contains(this.unitName))
            {
                ChangeState(ref test);
                return ResponseCode.TEST_OK;
            }

            ChangeState(ref waiting);
            return ResponseCode.ERROR;
        }

        private void StartAlarm()
        {
            //Observer design pattern
            foreach (Firefighters.Firefighter f in firefighters)
            {
                f.SendSms("Wezwanie alarmowe!");
            }
        }

        private void ChangeState(ref AlarmState alarmState)
        {
            state = alarmState;
            state.StartState();
        }



    }
}
