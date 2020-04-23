using System;

namespace DddInPractice
{
    public sealed class SnackMachine
    {
        public Money MoneyInside { get; private set; }
        public Money MoneyInTransaction { get; private set; }
        


        public void InserMoney(Money money)
        {
            MoneyInTransaction += money;
        }

        public void ReturnMoney()
        {
            //MoneyInTransaction = 0;
        }

        public void BuySnack()
        {
            MoneyInside += MoneyInTransaction;
            //MoneyInTransaction = 0;
        }
    }

    public class Money
    {
        public int OneCentCount { get; private set; }
        public int TenCentCount { get; private set; }
        public int QuarterCentCount { get; private set; }
        public int OneDollarCount { get; private set; }
        public int FiveDollarCount { get; private set; }
        public int TwentyDollarCount { get; private set; }

        public Money(
           int oneCentCount,
           int tenCentCount,
           int quarterCentCount,
           int oneDollarCount,
           int fiveDollarCount,
           int twentyDollarCount)
        {
            OneCentCount = oneCentCount;
            TenCentCount = tenCentCount;
            QuarterCentCount = quarterCentCount;
            OneDollarCount = oneDollarCount;
            FiveDollarCount = fiveDollarCount;
            TwentyDollarCount = twentyDollarCount;
        }

        public static Money operator +(Money money1, Money money2)
        {
            return new Money(
                money1.OneCentCount + money2.OneCentCount,
                money1.TenCentCount + money2.TenCentCount,
                money1.QuarterCentCount + money2.QuarterCentCount,
                money1.OneDollarCount + money2.OneDollarCount,
                money1.FiveDollarCount + money2.FiveDollarCount,
                money1.TwentyDollarCount + money2.TwentyDollarCount
            );
        }
    }
}
