
namespace LoggingSystem
{

    class Program
    {
        public static void Main(string[] args) {

            Logger infoMessage = new Logger(new MessageFormatter());
            infoMessage.LogMessage("The information provided is good :D.");

            Logger warningMessage = new Logger(new WarningFormatter());
            warningMessage.LogMessage("The warning provided is good :).");

            Logger errorMessage = new Logger(new ErrorFormatter());
            errorMessage.LogMessage("The errorMessage provided is bad bro :(.");

        }
    }

}
