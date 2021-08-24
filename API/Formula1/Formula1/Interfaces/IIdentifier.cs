using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Interfaces
{
    public interface IIdentifier<TEntity> where TEntity : class
    {
        TEntity getUser(string UserName);


    }
}
