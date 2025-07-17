using ExpenseTracker.Components.Data;
using ExpenseTracker.Components.Data.Models;
using ExpenseTracker.Components.Pages;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Components.Services
{
    public class ExpenseService
    {
        private readonly ExpenseTrackerContext _context;
        public ExpenseService(ExpenseTrackerContext context)
        {
            _context = context;
        }


        public List<Expense> findAllExpenses()
        {
            return _context.Expenses.Include(e => e.Category).ToList(); ;
        }
        public Expense addExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
            return expense;
        }
        public void removeExpense(Expense expense)
        {
            _context.Expenses.Remove(expense);
            _context.SaveChanges();
        }
        public Expense updateExpense(Expense expense)
        {
            _context.Expenses.Update(expense);
            _context.SaveChanges();
            return expense;
        }

        public List <Expense> findExpensesByCategoryId(int categoryId)
        {
            return _context.Expenses.Include(e => e.Category).Where(e => e.CategoryId == categoryId).ToList();
        }
        public decimal getTotalExpense()
		{
			return _context.Expenses.Sum(e => e.Amount);
		}
        public decimal getCurrentMonthExpense()
        {
            return _context.Expenses.Where(e => e.Date.Month == DateTime.Now.Month && e.Date.Year == DateTime.Now.Year).Sum(i => i.Amount);
        }

        public decimal findPlannedExpenses()
        {
            return _context.Expenses.Where(i => i.Planned == true).Sum(i => i.Amount);
        }
        public decimal findUnplannedExpenses()
        {
            return _context.Expenses.Where(i => i.Planned == false).Sum(i => i.Amount);
        }
    }
}
