using CommunityToolkit.Mvvm.ComponentModel;
using pos_demo.Data;
using pos_demo.Models;

namespace pos_demo.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        private readonly DatabaseService _databaseService;

        [ObservableProperty]
        private bool isLoading;

        [ObservableProperty]
        private MenuCategory[] categories = Array.Empty<MenuCategory>();

        public HomePageViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            InitializeAsync(); // Ensure initialization happens on ViewModel creation
        }

        public async void InitializeAsync()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                Categories = await _databaseService.GetAllMenuCategoriesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading categories: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
