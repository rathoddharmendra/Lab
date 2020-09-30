namespace Inheritance
{
    partial class Program
    {
        public class Installer
        {
            public Logger Logger { get; }

            public Installer(Logger logger)
            {
                Logger = logger;
            }

            public void Install()
            {
                Logger.Log("We are initiating the install procedure...");
            }
        }
    }
}
