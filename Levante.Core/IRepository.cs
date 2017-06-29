using Levante.Core.Models;
using System.Collections.Generic;

namespace Levante.Core
{
    public interface IRepository
    {
        IEnumerable<User> GetAll();
    }
}