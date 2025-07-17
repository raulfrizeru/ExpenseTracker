using ExpenseTracker.Components.Data;
using ExpenseTracker.Components.Data.Models;
using ExpenseTracker.Components.Pages;

namespace ExpenseTracker.Components.Services
{
    public class IncomeService
    {
        private readonly ExpenseTrackerContext _context;
        public IncomeService(ExpenseTrackerContext context)
        {
            _context = context;
        }

        public List<Income> findAllIncomes()
        {
           return _context.Incomes.ToList();
        }

        public Income addIncome(Income income)
        {
            _context.Incomes.Add(income);
            _context.SaveChanges();
            return income;
        }

        public void removeIncome(Income income)
        {
            _context.Incomes.Remove(income);
            _context.SaveChanges();
        }

        public Income updateIncome(Income income)
        {
            _context.Incomes.Update(income);
            _context.SaveChanges();
            return income;
        }
        public Income findIncomeById(int id)
		{
			return _context.Incomes.Where(i => i.Id == id).Single();
		}

        public decimal getTotalIncome()
		{
			return _context.Incomes.Sum(i => i.Amount);
		}
        public decimal getCurrentMonthIncome()
        {
            return _context.Incomes.Where(i => i.Date.Month == DateTime.Now.Month && i.Date.Year == DateTime.Now.Year)
				.Sum(i => i.Amount);
        }

        public List<Income> findIncomesByDateRange(DateTime startDate, DateTime endDate)
        {
            return _context.Incomes.Where(i => i.Date >= startDate && i.Date <= endDate).ToList();
        }
            
    }
}
