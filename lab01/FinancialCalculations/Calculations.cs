using System;
using System.Threading.Tasks;

namespace FinancialCalculations
{
    public class Calculations
	{

		public static decimal CalculateFutureValue(decimal monthlyInvestment, 
			decimal monthlyInterestRate, int months)
		{
            double dMonthlyInvestment = Convert.ToDouble(monthlyInvestment);
            double dMonthlyInterestRate = Convert.ToDouble(monthlyInterestRate);
            double dMonths = Convert.ToDouble(months);
            double dFutureValue = 
                dMonthlyInvestment *
                (Math.Pow(1 + dMonthlyInterestRate, dMonths) - 1) / 
                dMonthlyInterestRate;
            decimal futureValue = Convert.ToDecimal(dFutureValue);

            return futureValue;
		}

		public static decimal CalculateMonthlyInvestment(decimal futureValue, 
			decimal monthlyInterestRate, int months)
		{
			double dFutureValue = Convert.ToDouble(futureValue);
			double dMonthlyInterestRate = Convert.ToDouble(monthlyInterestRate);
			double dMonths = Convert.ToDouble(months);

            double dMonthlyInvestment =
                dMonthlyInterestRate * dFutureValue / 
                (Math.Pow(1 + dMonthlyInterestRate, dMonths) - 1);

			decimal monthlyInvestment = 
				Convert.ToDecimal(dMonthlyInvestment);

			return monthlyInvestment;
		}

		public static double CalculateSYDDepreciation(double cost, 
			double salvage, double life, double period)
		{
			double SYDValue = 
				(cost-salvage) * (life-period+1) * 2 / 
					((life)*(life+1));
			return SYDValue;
		}

	}
}
