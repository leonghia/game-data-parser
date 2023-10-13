// Reading the filename from the console

using GameDataParser.Model;

namespace GameDataParser.DataAccess
{
    public interface IVideoGamesDeserializer
    {
        List<VideoGame> Deserialize(string fileName, string fileContent);
    }
}