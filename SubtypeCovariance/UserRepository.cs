﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    //author Alexander Hagmann
    //version 11/24/2019

    public class UserRepository : IEntityRepository<User>
    {
        // returns the id for a user and accepts the IEntity interface
        public User GetByID(Guid id)
        {
            return new User(id);
        }
    }
}
