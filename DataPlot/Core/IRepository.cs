using Core.Models;
using System.Collections.Generic;

namespace Core
{
    public interface IRepository
    {
        IEnumerable<Channel> GetAll(string filePath);
    }
}
