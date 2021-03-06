﻿using Common.Calculations;

namespace ActionHandlers.Calculations
{
    public class ExpressCheckoutFeeCalculation : ICalculation<decimal>
    {
        private const decimal PercentageFee = 3.4m;
        private const decimal FixedFee = 0.45m;

        private readonly decimal _amount;

        public ExpressCheckoutFeeCalculation(decimal amount)
        {
            _amount = amount;
        }

        /// <summary>
        /// 3.4% + $0.45 per transaction
        /// </summary>
        /// <returns></returns>
        public CalculationResult<decimal> Calculate()
        {
            decimal percentageOfTransaction = _amount * PercentageFee / 100;
            decimal totalFee = percentageOfTransaction + FixedFee;

            return new CalculationResult<decimal>(totalFee);
        }
    }
}