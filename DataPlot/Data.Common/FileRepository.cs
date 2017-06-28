using System;
using System.Collections.Generic;
using Core;
using Core.Models;
using Data.Common.Interfaces;

namespace Data.Common
{
    public class FileRepository : IRepository
    {
        private readonly IFileExplorer _explorer;

        public FileRepository(IFileExplorer explorer)
        {
            _explorer = explorer;
        }

        public IEnumerable<Channel> GetAll(string filePath)
        {
            var extention = _explorer.GetFileExtention(filePath);

            IReader reader;
            switch (extention)
            {
                case ".csv":
                    reader = new CsvReader();
                    break;

                case ".json":
                    reader = new JsonReader();
                    break;

                default:
                    reader = null;
                    break;
            }
            return reader?.GetAll(filePath);
        }
    }
}
