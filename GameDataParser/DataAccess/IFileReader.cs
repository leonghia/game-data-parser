// Reading the filename from the console

namespace GameDataParser.DataAccess
{
    public interface IFileReader
    {
        string Read(string fileName);
    }
}