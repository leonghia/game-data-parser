// Reading the filename from the console



using GameDataParser.Model;

namespace GameDataParser.UserInteraction
{
    public interface IGamesPrinter
    {
        void Print(List<VideoGame> videoGames);
    }
}