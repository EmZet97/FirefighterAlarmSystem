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

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public String getSurname()
        {
            return surname;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public String getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        
    public void sendSms(string content)
        {
            Console.WriteLine("Wysyłam SMS do" + this.name + " " + this.surname);
        }

    }
}
