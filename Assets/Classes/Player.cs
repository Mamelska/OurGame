using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    class Player
    {
        private String login;
        public int ageGroup;
        private string password;

        public Player(String login)
        {
            this.login = login;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setAgeGroup(int age)
        {
            ageGroups group;
            if (age <= 5)
            {
                group = ageGroups.Five;
            }
            else if (age <= 10)
            {
                group = ageGroups.Ten;
            }
            else if (age <= 15)
            {
                group = ageGroups.Fifteen;
            }
            else if (age <= 20)
            {
                group = ageGroups.Twenty;
            }
            else if (age <= 30)
            {
                group = ageGroups.Thirty;
            }
            else if (age <= 40)
            {
                group = ageGroups.Forty;
            }
            else if (age <= 50)
            {
                group = ageGroups.Fifty;
            }
            else
            {
                group = ageGroups.FiftyPlus;
            }
            this.ageGroup = (int)group;
        }
    }
    enum ageGroups { Five, Ten, Fifteen, Twenty, Thirty, Forty, Fifty, FiftyPlus };
}