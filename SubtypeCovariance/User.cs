using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class User : Entity
    {
        //author Alexander Hagmann
        //version 11/24/2019

            //Modified User to accept the Interface
        public User(Guid newID) : base(newID)
        {
            EmailAddress = "";
        }
        public string EmailAddress { get; private set; }

        public DateTime DateOfBirth { get; private set; }
    }
}
