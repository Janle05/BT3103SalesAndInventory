using SalesInventory.businesslogic;
using SalesInventory.Repository;

namespace SalesInventory.BusinessLogic
{
    public class CategoryService
    {
        private readonly CategoryRepository repository;

        public CategoryService()
        {
            repository = new CategoryRepository();
        }

        public void AddCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName))
                throw new System.Exception(
                    "Category name is required.");

            repository.AddCategory(category);
        }

        public List<Category> GetAllCategories()
        {
            return repository.GetAllCategories();
        }

        public void UpdateCategory(Category category)
        {
            repository.UpdateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            repository.DeleteCategory(id);
        }

        public List<Category> SearchCategories(string keyword)
        {
            return repository.SearchCategories(keyword);
        }
    }
}