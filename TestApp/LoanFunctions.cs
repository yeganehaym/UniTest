namespace TestApp
{
    public class LoanFunctions
    {
        public int CalculateInterest(int amount, int year, int percent)
        {
            var month = 12;
            var totalMonth = month * year;
            var totalPercent = percent * year;
            var interest = amount * totalPercent / 100;
            return interest;
        }
    }
}