namespace ExpenseTracker.Components.Data.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool Planned { get; set; } = false;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
