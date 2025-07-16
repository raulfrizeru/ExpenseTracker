using ExpenseTracker.Components.Data;
using ExpenseTracker.Components.Data.Models;

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
            
    }
}
