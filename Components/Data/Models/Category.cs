﻿namespace ExpenseTracker.Components.Data.Models
{
    public class Category
    {
        public int? Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public ICollection<Expense> Expenses { get; } = new List<Expense>();
    }
}
