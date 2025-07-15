namespace ExpenseTracker.Components.Data.Models
{
    public enum Type
    {
        Salary,
        Scholarship,
        Gift,
        LuckyWinnings
    }
    public class Income
    {
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public Type Type { get; set; } = Type.Salary;
    }
}
