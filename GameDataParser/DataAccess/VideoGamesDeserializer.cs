// Reading the filename from the console
using GameDataParser.Model;
using GameDataParser.UserInteraction;
using System.Text.Json;

namespace GameDataParser.DataAccess
{
    public class VideoGamesDeserializer : IVideoGamesDeserializer
    {
        private readonly IUserInteractor _userInteractor;

        public VideoGamesDeserializer(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public List<VideoGame> Deserialize(string fileName, string fileContent)
        {
            try
            {

                // Deserialize the file content into list of video games
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContent);
            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError($"JSON in {fileName} file was not in valid format. JSON body: ");
                _userInteractor.PrintError(fileContent);

                throw new JsonException($"{ex.Message} The file is {fileName}.", ex);
            }
        }
    }
}