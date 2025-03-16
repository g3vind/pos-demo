namespace pos_demo.Data
{
    public static class SeedData
    {
        public static List<MenuCategory> GetMenuCategories()
        {
            return new List<MenuCategory>
            {
                new MenuCategory { Id = 1, Name = "Appetizers", Icon = "appetizers.png" },
                new MenuCategory { Id = 2, Name = "Entrees", Icon = "entrees.png" },
                new MenuCategory { Id = 3, Name = "Desserts", Icon = "desserts.png" },
                new MenuCategory { Id = 4, Name = "Beverages", Icon = "beverages.png" },
                new MenuCategory { Id = 5, Name = "Salads", Icon = "salads.png" },
                new MenuCategory { Id = 6, Name = "Sandwiches", Icon = "sandwiches.png" },
                new MenuCategory { Id = 7, Name = "Soups", Icon = "soups.png" },
                new MenuCategory { Id = 8, Name = "Seafood", Icon = "seafood.png" },
                new MenuCategory { Id = 9, Name = "Pasta", Icon = "pasta.png" },
                new MenuCategory { Id = 10, Name = "Breakfast", Icon = "breakfast.png" }
            };
        }

        public static List<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem { Id = 1, Name = "Spring Rolls", Icon = "spring_rolls.png", Price = 5.99 },
                new MenuItem { Id = 2, Name = "Mozzarella Sticks", Icon = "mozzarella_sticks.png", Price = 6.99 },
                new MenuItem { Id = 3, Name = "Grilled Chicken", Icon = "grilled_chicken.png", Price = 12.99 },
                new MenuItem { Id = 4, Name = "Steak with Vegetables", Icon = "steak_veggies.png", Price = 19.99 },
                new MenuItem { Id = 5, Name = "Chocolate Cake", Icon = "chocolate_cake.png", Price = 6.50 },
                new MenuItem { Id = 6, Name = "Apple Pie", Icon = "apple_pie.png", Price = 5.50 },
                new MenuItem { Id = 7, Name = "Fresh Orange Juice", Icon = "orange_juice.png", Price = 3.99 },
                new MenuItem { Id = 8, Name = "Iced Coffee", Icon = "iced_coffee.png", Price = 4.50 },
                new MenuItem { Id = 9, Name = "Caesar Salad", Icon = "caesar_salad.png", Price = 7.99 },
                new MenuItem { Id = 10, Name = "Greek Salad", Icon = "greek_salad.png", Price = 8.50 },
                new MenuItem { Id = 11, Name = "Turkey Club Sandwich", Icon = "turkey_club.png", Price = 9.99 },
                new MenuItem { Id = 12, Name = "Grilled Cheese Sandwich", Icon = "grilled_cheese.png", Price = 6.50 },
                new MenuItem { Id = 13, Name = "Tomato Soup", Icon = "tomato_soup.png", Price = 5.99 },
                new MenuItem { Id = 14, Name = "Chicken Noodle Soup", Icon = "chicken_soup.png", Price = 6.50 },
                new MenuItem { Id = 15, Name = "Grilled Salmon", Icon = "grilled_salmon.png", Price = 17.99 },
                new MenuItem { Id = 16, Name = "Shrimp Scampi", Icon = "shrimp_scampi.png", Price = 18.50 },
                new MenuItem { Id = 17, Name = "Spaghetti Bolognese", Icon = "spaghetti_bolognese.png", Price = 13.50 },
                new MenuItem { Id = 18, Name = "Alfredo Pasta", Icon = "alfredo_pasta.png", Price = 12.99 },
                new MenuItem { Id = 19, Name = "Pancakes with Syrup", Icon = "pancakes.png", Price = 7.99 },
                new MenuItem { Id = 20, Name = "Omelette with Toast", Icon = "omelette.png", Price = 8.99 }
            };
        }

        public static List<MenuItemCategoryMapping> GetMenuItemCategoryMappings()
        {
            return new List<MenuItemCategoryMapping>
            {
                // Appetizers
                new MenuItemCategoryMapping { Id = 1, MenuCategoryId = 1, MenuItemId = 1 },
                new MenuItemCategoryMapping { Id = 2, MenuCategoryId = 1, MenuItemId = 2 },

                // Entrees
                new MenuItemCategoryMapping { Id = 3, MenuCategoryId = 2, MenuItemId = 3 },
                new MenuItemCategoryMapping { Id = 4, MenuCategoryId = 2, MenuItemId = 4 },

                // Desserts
                new MenuItemCategoryMapping { Id = 5, MenuCategoryId = 3, MenuItemId = 5 },
                new MenuItemCategoryMapping { Id = 6, MenuCategoryId = 3, MenuItemId = 6 },

                // Beverages
                new MenuItemCategoryMapping { Id = 7, MenuCategoryId = 4, MenuItemId = 7 },
                new MenuItemCategoryMapping { Id = 8, MenuCategoryId = 4, MenuItemId = 8 },

                // Salads
                new MenuItemCategoryMapping { Id = 9, MenuCategoryId = 5, MenuItemId = 9 },
                new MenuItemCategoryMapping { Id = 10, MenuCategoryId = 5, MenuItemId = 10 },

                // Sandwiches
                new MenuItemCategoryMapping { Id = 11, MenuCategoryId = 6, MenuItemId = 11 },
                new MenuItemCategoryMapping { Id = 12, MenuCategoryId = 6, MenuItemId = 12 },

                // Soups
                new MenuItemCategoryMapping { Id = 13, MenuCategoryId = 7, MenuItemId = 13 },
                new MenuItemCategoryMapping { Id = 14, MenuCategoryId = 7, MenuItemId = 14 },

                // Seafood
                new MenuItemCategoryMapping { Id = 15, MenuCategoryId = 8, MenuItemId = 15 },
                new MenuItemCategoryMapping { Id = 16, MenuCategoryId = 8, MenuItemId = 16 },

                // Pasta
                new MenuItemCategoryMapping { Id = 17, MenuCategoryId = 9, MenuItemId = 17 },
                new MenuItemCategoryMapping { Id = 18, MenuCategoryId = 9, MenuItemId = 18 },

                // Breakfast
                new MenuItemCategoryMapping { Id = 19, MenuCategoryId = 10, MenuItemId = 19 },
                new MenuItemCategoryMapping { Id = 20, MenuCategoryId = 10, MenuItemId = 20 }
            };
        }
    }
}
