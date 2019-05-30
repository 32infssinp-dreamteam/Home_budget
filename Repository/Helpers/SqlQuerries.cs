namespace Repository.Helpers
{
    public class SqlQuerries
    {
        public const string CreateTableCategories = @"
CREATE TABLE Categories (
    Id      INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    Name    TEXT NOT NULL,
    Color   TEXT NOT NULL
);";

        public const string CreateTableExpenses = @"
CREATE TABLE Expenses (
    Id          INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    CategoryId  INTEGER NOT NULL,
    Value       NUMERIC NOT NULL,
    Year        INTEGER NOT NULL,
    Month       INTEGER NOT NULL,
    Day         INTEGER NOT NULL,
    Date        TEXT NOT NULL,
    Description TEXT NOT NULL,
    ModificationTime TEXT NOT NULL,
    CONSTRAINT FK_Expenses_CategoryId FOREIGN KEY (CategoryId) REFERENCES Categories (Id)
);";

        public const string CreateTableMonthlyBudgets = @"
CREATE TABLE MonthlyBudgets (
    Id          INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    Year        INTEGER NOT NULL,
    Month       INTEGER NOT NULL,
    BudgetValue NUMERIC NOT NULL,
    CONSTRAINT UQ_MonthlyBudgets_Year_Month UNIQUE (Year, Month)
);";

        public const string AddCategory = @"
INSERT INTO Categories (Name, Color)
VALUES (@Name, @Color);";

        public const string EditCategory = @"
UPDATE Categories SET
    Name = @Name,
    Color = @Color
WHERE Id = @Id;";

        public const string GetCategories = @"
SELECT Id, Name, Color
FROM Categories;";

        public const string DeleteCategory = @"
DELETE FROM Categories
WHERE Id = @CategoryId;";

        public const string IsCategoryUsed = @"
SELECT EXISTS (
    SELECT 1
    FROM Expenses
    WHERE CategoryId = @CategoryId);";

        public const string AddExpense = @"
INSERT INTO Expenses (CategoryId, Value, Year, Month, Day, Date, Description, ModificationTime)
VALUES (@CategoryId, @Value, @Year, @Month, @Day, @Date, @Description, @ModificationTime);";

        public const string EditExpense = @"
UPDATE Expenses SET
    CategoryId = @CategoryId,
    Value = @Value,
    Year = @Year,
    Month = @Month,
    Day = @Day,
    Date = @Date,
    Description = @Description,
    ModificationTime = @ModificationTime
WHERE Id = @Id;";

        public const string DeleteExpense = @"
DELETE FROM Expenses
WHERE Id = @Id;";

        public const string GetExpenseById = @"
SELECT Id, CategoryId, Value, Year, Month, Day, Date, Description, ModificationTime
FROM Expenses
WHERE Id = @Id;";

        public const string GetExpensesByDate = @"
SELECT Id, CategoryId, Value, Year, Month, Day, Date, Description, ModificationTime
FROM Expenses
WHERE Year = @Year AND Month = @Month AND Day = @Day;";
        
        public const string GetExpensesByMonth = @"
SELECT Id, CategoryId, Value, Year, Month, Day, Date, Description, ModificationTime
FROM Expenses
WHERE Year = @Year AND Month = @Month;";

        public const string AddMonthlyBudget = @"
INSERT INTO MonthlyBudgets (Year, Month, BudgetValue)
VALUES (@Year, @Month, @BudgetValue);";

        public const string EditMonthlyBudget = @"
UPDATE MonthlyBudgets SET
    BudgetValue = @BudgetValue
WHERE Year = @Year AND Month = @Month;";

        public const string DeleteMonthlyBudget = @"
DELETE FROM MonthlyBudgets
WHERE Year = @Year AND Month = @Month;";

        public const string GetMonthlyBudget = @"
SELECT Id, BudgetValue
FROM MonthlyBudgets
WHERE Year = @Year AND Month = @Month;";
    }
}