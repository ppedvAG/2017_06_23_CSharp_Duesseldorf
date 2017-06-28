using Xunit;

namespace Data.Common.Tests
{
    public class FileExplorerTests
    {
        [Fact]
        public void CanCreateInstance()
        {
            var explorer = new FileExplorer();
            Assert.NotNull(explorer);
        }
        [Theory]
        [InlineData(@"C:\a.csv", ".csv")]
        [InlineData(@"C:\Folder\a.csv", ".csv")]
        [InlineData(@"C:\Folder\FolderInAFolder\a.csv", ".csv")]
        [InlineData(@"C:\Folder\FolderInAFolder\FolderInAFolderInAFolder\a.csv", ".csv")]
        [InlineData(@"D:\a.txt", ".txt")]
        [InlineData(@"D:\a.json", ".json")]
        public void GetFileExtention_returns_correct_Extention(string path, string expectedExtention)
        {
            var explorer = new FileExplorer();

            var extention = explorer.GetFileExtention(path);

            Assert.Equal(expectedExtention, extention);
        }
    }
}
