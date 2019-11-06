using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefighterAlarmSystem.Firefighters
{
    class Firefighter : IFirefighter
    {
        String name;
        String surname;
        String phoneNumber;

        public Firefighter(String name, String surname, String phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getSurname()
        {
            return surname;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public String getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        
    public void sendSms(String content)
        {
            //System.out.println("Wysyłam SMS do" + this.name + " " + this.surname);
        }

    }
}
