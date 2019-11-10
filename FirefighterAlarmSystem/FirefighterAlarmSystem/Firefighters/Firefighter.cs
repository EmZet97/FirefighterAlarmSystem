using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.Firefighters
{
    class Firefighter : IFirefighter
    {
        string name;
        string surname;
        string phoneNumber;

        public Firefighter(string name, string surname, string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        
    public void SendSms(string content)
        {
            Console.WriteLine("Wysyłam SMS o treści '" + content + "' do " + this.name + " " + this.surname);
        }

    }
}
