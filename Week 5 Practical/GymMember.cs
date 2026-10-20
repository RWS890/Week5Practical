using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5_Practical
{
    class GymMember
    {
        private int memberId;
        private string name;

        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public GymMember(int gymMemberID, string gymName)
        {
            MemberId = gymMemberID;
            Name = gymName;
        }

    }
}
