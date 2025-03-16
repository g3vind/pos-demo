using pos_demo.Models;
using SQLite;
using MenuItem = pos_demo.Models.MenuItem;

namespace pos_demo.Data
{
    public class DatabaseService : IAsyncDisposable
    {
        private readonly SQLiteAsyncConnection _connection;

        public DatabaseService()
        {
            string dbPath = GetDatabasePath();
            _connection = new SQLiteAsyncConnection(dbPath, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache);
        }

        private static string GetDatabasePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "pos_demo.db");
        }

        public async Task InitializeDatabaseAsync()
        {
            try
            {
                await Task.WhenAll(
                    _connection.CreateTableAsync<MenuCategory>(),
                    _connection.CreateTableAsync<MenuItem>(),
                    _connection.CreateTableAsync<MenuItemCategoryMapping>(),
                    _connection.CreateTableAsync<Order>(),
                    _connection.CreateTableAsync<OrderItem>()
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database Initialization Failed: {ex.Message}");
            }
        }

        public async Task SeedDataAsync()
        {
            try
            {
                var firstCat = await _connection.Table<MenuCategory>().FirstOrDefaultAsync();
                if(firstCat != null)
                {
                    return;
                }

                await Task.WhenAll(
                    _connection.InsertAllAsync(SeedData.GetMenuCategories()),
                    _connection.InsertAllAsync(SeedData.GetMenuItems()),
                    _connection.InsertAllAsync(SeedData.GetMenuItemCategoryMappings())
                );

                var data = await _connection.Table<MenuCategory>().ToArrayAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Seeding Data Failed: {ex.Message}");
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (_connection != null)
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<MenuCategory[]> GetAllMenuCategoriesAsync()
        {
            return await _connection.Table<MenuCategory>().ToArrayAsync();
        }

        public async Task<MenuItem[]> GetMenuItemsByCategoryAsync(int categoryId)
        {
            var query = @"SELECT menu.*
                          FROM MenuItem AS menu 
                          INNER JOIN MenuItemCategoryMapping AS mapping
                          ON menu.Id = mapping.MenuItemId
                          WHERE mapping.MenuCategoryId = ?";

            return (await _connection.QueryAsync<MenuItem>(query, categoryId)).ToArray();
        }
    }
}
