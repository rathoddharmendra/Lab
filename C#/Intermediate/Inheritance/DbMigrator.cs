namespace Inheritance
{
    partial class Program
    {
        public class DbMigrator
        {
            private readonly Logger _logger;

            public DbMigrator(Logger logger)
            {
                this._logger = logger;
            }

            public void Migrate()
            {
                _logger.Log("We are migrating blah blah blah...");
            }
        }
    }
}
