using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IBusinessBase : IRepositoryBase<T> where T : class
    {

    }
}
