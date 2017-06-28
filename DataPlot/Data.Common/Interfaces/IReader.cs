using Core.Models;
using System.Collections.Generic;

namespace Data.Common.Interfaces
{
    public interface IReader
    {
        IEnumerable<Channel> GetAll(string filePath);
    }
}
