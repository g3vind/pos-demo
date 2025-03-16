using pos_demo.ViewModels;

namespace pos_demo.Pages
{
    public partial class MainPage : ContentPage
    {
        private readonly HomePageViewModel _viewModel;
        public MainPage(HomePageViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
            Initialize();
        }

        private void Initialize()
        {
            _viewModel.InitializeAsync();
        }
    }
}
