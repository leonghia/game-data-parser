// Reading the filename from the console

namespace GameDataParser.UserInteraction
{
    public class ConsoleUserInteractor : IUserInteractor
    {
        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadValidFilePath()
        {
            string? fileName = default;
            bool isFilePathValid = false;

            while (!isFilePathValid)
            {
                Console.Write("Enter file name: ");
                fileName = Console.ReadLine();

                if (fileName is null) Console.WriteLine("The file name cannot be null.");
                else if (fileName == string.Empty) Console.WriteLine("The file name cannot be empty.");
                else if (!File.Exists(fileName)) Console.WriteLine("The file does not exist");
                else isFilePathValid = true;
            }

            return fileName;
        }
    }
}