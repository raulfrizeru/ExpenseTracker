using ExpenseTracker.Components.Data;
using ExpenseTracker.Components.Data.Models;
using ExpenseTracker.Components.Pages;

namespace ExpenseTracker.Components.Services
{
    public class CategoryService
    {
        private readonly ExpenseTrackerContext _context;
        public CategoryService(ExpenseTrackerContext context)
        {
            _context = context;
        }

        public List<Category> findAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category addCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void removeCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
            
        }
        
        
    }
}
