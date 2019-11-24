using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    //author Alexander Hagmann
    //version 11/24/2019

        // Interface for implementing Users and Entitys
    public interface IEntityRepository<TEntity>
        where TEntity : Entity
    {
        TEntity GetByID(Guid id);
    }
}
