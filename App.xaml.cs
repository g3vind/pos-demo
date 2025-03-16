using pos_demo.Data;

namespace pos_demo
{
    public partial class App : Application
    {
        private readonly DatabaseService databaseService;
        public App(DatabaseService databaseService)
        {
            InitializeComponent();

            MainPage = new AppShell();
            this.databaseService = databaseService;
        }

        protected override async void OnStart()
        {
            base.OnStart();
            await databaseService.InitializeDatabaseAsync();
            await databaseService.SeedDataAsync();
        }
    }
}
